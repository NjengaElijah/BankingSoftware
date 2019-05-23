using System;
using System.Windows.Forms;
using Moshi_Bank.Models;

namespace Moshi_Bank.Views
{
    public partial class RepayLoan : Form
    {
        public RepayLoan()
        {
            InitializeComponent();
            API.filter(txtAccNo, txtLoanNo, txtAmount);
        }
        Loan loan = null; Account account; User user;
        private void btnAccNo_Click(object sender, EventArgs e)
        {
            loan = API.Controllers.Loans.FindByAccountNumber(txtAccNo.Text)[0];
            if (loan != null)
            {
                account = API.Controllers.Accounts.FetchByAccountNumber(loan.Account.Number);
                DisplayData();
            }

        }
        private void btnLoanNo_Click(object sender, EventArgs e)
        {
            loan = API.Controllers.Loans.FindById(txtLoanNo.Text);
            if (loan != null)
            {
                account = API.Controllers.Accounts.FetchByAccountNumber(loan.Account.Number);
                DisplayData();
            }
        }
        private void DisplayData()
        {

            btnProcessPayment.Visible = true;
            if (loan.Status == Models.Loan.STATUS.REJECTED)
            {
                API.Message("Sorry ! Your loan was rejected", MessageBoxIcon.Error);
                btnProcessPayment.Visible = false;
            }
            else if (loan.Status == Models.Loan.STATUS.CRITICAL)
            {
                API.Message("Sorry ! Your loan has an issue.Please visit the Manager", MessageBoxIcon.Error);
                btnProcessPayment.Visible = false;
            }
            else if (loan.Status == Models.Loan.STATUS.PENDING)
            {
                API.Message("Sorry ! Your loan is still pending", MessageBoxIcon.Information);
                btnProcessPayment.Visible = false;
            }
            else if (loan.Status == Models.Loan.STATUS.COMPLETE)
            {
                API.Message("Your Loan has alredy been completed", MessageBoxIcon.Information);
                btnProcessPayment.Visible = false;
            }

            lblAccNames.Text = account.Names;
            lblAccNo.Text = account.Number;
            lblBalance.Text = loan.Balance.ToString();
            lblLoanAmount.Text = loan.Amount.ToString();
            lblLoanNo.Text = loan.Id;
            lblMonthlyPay.Text = loan.MonthlyAmount.ToString();
            txtAccBalance.Text = account.Balance.ToString();

            if (account != null)
                user = API.Controllers.Users.FindById(account.UserId);
            if (user != null)
                pictureBox1.Image = API.ImageFromByte(user.UserPhoto);
        }

        private void RepayLoan_Load(object sender, EventArgs e)
        {
            API.filter(txtAccNo, txtLoanNo);
        }

        private void lnkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (account == null || user == null || loan == null )
            {

            }
            else
            {
                Models.SimpleInterest si = new Models.SimpleInterest(loan.Principal, loan.Rate, loan.Time, loan.StandingCharge);
                si.Calculate();
                SimpleInterestLoan siLoan = new SimpleInterestLoan(account, loan, si);
                siLoan.ShowDialog();
            }
        }

        private void btnProcessPayment_Click(object sender, EventArgs e)
        {
            if (account == null || user == null || loan == null || txtAmount.Text.Trim().Equals(String.Empty))
            {

            }
            else
            {
                try
                {

                    Double amount = Convert.ToDouble(txtAmount.Text);

                    //create the General Transaction
                    Account SystemAcc = API.Controllers.Accounts.FetchByAccountNumber(0);
                    Transaction Transaction = new Transaction
                    {
                        TransationGUId = Guid.NewGuid().ToString(),
                        TransationType = Transaction.TransactionTypes.LOAN_PAYMENT
                    };
                    API.Controllers.Transaction.Create(Transaction);
                    Transaction = API.Controllers.Transaction.FindByGUID(Transaction.TransationGUId);

                    TransactionDescription SysTransacDescription = new TransactionDescription
                    {
                        CreditAccount = SystemAcc,
                        DebitAccount = SystemAcc,
                        GUID = Guid.NewGuid().ToString(),
                        Description = "Loan Repayment For Account { " + account.Number + " } on Loan {" + loan.Id + "}"
                    };
                    API.Controllers.TransactionDescription.Create(SysTransacDescription);
                    SysTransacDescription = API.Controllers.TransactionDescription.FindByGUID(SysTransacDescription.GUID);


                    TransactionDescription AccountLoanTransacDescription = new TransactionDescription
                    {
                        CreditAccount = SystemAcc,
                        DebitAccount = SystemAcc,
                        GUID = Guid.NewGuid().ToString(),
                        Description = "Loan Repayment Amount { " + amount + " } for Loan {" + loan.Id + "}"
                    };
                    API.Controllers.TransactionDescription.Create(AccountLoanTransacDescription);
                    AccountLoanTransacDescription = API.Controllers.TransactionDescription.FindByGUID(AccountLoanTransacDescription.GUID);



                    if (txtAmount.Text.Trim().Equals(String.Empty))
                    {

                    }
                    else if ((decimal)amount > loan.Balance)
                    { //process overflow
                        double extra = amount - (double)loan.Balance;
                       

                        CreditDebit sysCredit = new CreditDebit
                        {
                            Account = SystemAcc,
                            Transaction = Transaction,
                            Credit = (double)loan.Balance,
                            TransactionDescription = SysTransacDescription,
                            TransactionType = Transaction.TransactionTypes.LOAN_PAYMENT
                        };
                        CreditDebit accCredDeb = new CreditDebit
                        {
                            Account = account,
                            Transaction = Transaction,
                            Credit = extra,
                            Debit = 0,
                            PrevBalance = (double)loan.Balance,
                            NewBalance = (double)loan.Balance - amount,
                            TransactionDescription = AccountLoanTransacDescription
                        };


                        API.Controllers.CreditDebit.Create(sysCredit);
                        API.Controllers.CreditDebit.CreateForLoans(accCredDeb);
                        API.Controllers.Loans.UpdateBalance(loan, account, loan.Balance);
                        API.Message("Loan Repayment Applied Successfully!", MessageBoxIcon.Information);

                        // 
                        Transaction transaction = new Transaction { TransationGUId = Guid.NewGuid().ToString(), TransationType = Transaction.TransactionTypes.DEPOSIT };
                        API.Controllers.Transaction.Create(transaction);
                        transaction = API.Controllers.Transaction.FindByGUID(transaction.TransationGUId);
                        TransactionDescription transactionDescription = new TransactionDescription { Description = "Deposit from Loan Overflow Loan {" + loan.Id + "} , Overflow {" + extra + "}", GUID = Guid.NewGuid().ToString(), CreditAccount = account, DebitAccount = account };
                        API.Controllers.TransactionDescription.Create(transactionDescription);
                        transactionDescription = API.Controllers.TransactionDescription.FindByGUID(transactionDescription.GUID);
                        CreditDebit creditDebit = new CreditDebit { Credit = (double)extra, Transaction = transaction, TransactionDescription = transactionDescription, Account = account, TransactionType = Transaction.TransactionTypes.DEPOSIT };
                        API.Controllers.CreditDebit.Create(creditDebit);
                        API.Controllers.Loans.UpdateStatus(loan, Loan.STATUS.COMPLETE);
                        API.Message("Overflow Deposit Successfull", MessageBoxIcon.Information);

                        loan = API.Controllers.Loans.FindById(loan.Id);
                        if (loan != null)
                            account = API.Controllers.Accounts.FetchByAccountNumber(loan.Account.Number);
                        DisplayData();
                    }
                    else
                    {
                        CreditDebit sysCredit = new CreditDebit
                        {
                            Account = SystemAcc,
                            Transaction = Transaction,
                            Credit = amount,
                            TransactionDescription = SysTransacDescription,
                            TransactionType = Transaction.TransactionTypes.LOAN_PAYMENT
                        };
                        CreditDebit accCredDeb = new CreditDebit
                        {
                            Account = account,
                            Transaction = Transaction,
                            Credit = amount,
                            Debit = 0,
                            PrevBalance = (double)loan.Balance,
                            NewBalance = (double)loan.Balance - amount,
                            TransactionDescription = AccountLoanTransacDescription
                        };


                        API.Controllers.CreditDebit.Create(sysCredit);
                        API.Controllers.CreditDebit.CreateForLoans(accCredDeb);
                        API.Controllers.Loans.UpdateBalance(loan, account, (decimal)amount);
                        API.Controllers.Loans.UpdateStatus(loan, Loan.STATUS.INCOMPLETE);
                        API.Message("Loan Repayment Applied Successfully!", MessageBoxIcon.Information);

                        loan = API.Controllers.Loans.FindById(loan.Id);
                        if (loan != null)
                            account = API.Controllers.Accounts.FetchByAccountNumber(loan.Account.Number);
                        DisplayData();

                    }
                }
                catch (Exception ex)
                {
                    API.Message(ex.Message, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
