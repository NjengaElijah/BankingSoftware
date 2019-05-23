using System;
using System.Windows.Forms;
using Moshi_Bank.Models;
namespace Moshi_Bank.Views
{
    public partial class SimpleInterestLoan : Form
    {
        SimpleInterest si;
        public SimpleInterestLoan(Account account, Loan loan, SimpleInterest si)
        {
            InitializeComponent();
            Account = account;
            Loan = loan;
            this.si = si;
        }
        private Account Account { get; set; }
        private Loan Loan { get; set; }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void datagridFixedDep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SImpleInterestLoan_Load(object sender, EventArgs e)
        {
            txtAccBalance.Text = Account.Balance.ToString();
            txtAccNames.Text = Account.Names;
            txtPrincipal.Text = Loan.Principal.ToString();
            txtInterest.Text = si.Interest + "";
            txtAmount.Text = si.Amount.ToString();
            txtRate.Text = si.Rate + "%";
            txtTime.Text = si.Time + " M";
            label8.Text = Loan.Id;
            Decimal pBal = si.Amount;
            cboAction.SelectedIndex = Loan.Status - 1;
            for (int x = 1; x <= si.Time; x++)
            {
                pBal -= si.MonthlyAmount;
                datagridFixedDep.Rows.Add(
                    x,
                    si.MonthlyAmount,
                    si.MonthlyInterest,
                    pBal
                    );
            }
        }

        private void btnApplyAction_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboAction.SelectedIndex + 1 == Loan.STATUS.APPROVED)
                {
                    Account account = API.Controllers.Accounts.FetchByAccountNumber(0);
                    //API.Message(account.Balance.ToString(), MessageBoxIcon.Asterisk);
                    Transaction transaction = new Transaction
                    {
                        TransationGUId = Guid.NewGuid().ToString(),
                        TransationType = Transaction.TransactionTypes.STANDING_CHARGE
                    };
                    API.Controllers.Transaction.Create(transaction);
                    transaction = API.Controllers.Transaction.FindByGUID(transaction.TransationGUId);

                    TransactionDescription transDes = new TransactionDescription
                    {
                        GUID = Guid.NewGuid().ToString(),
                        CreditAccount = account,
                        DebitAccount = account,
                        Description = "Loan Standing Charge , Loan{" + Loan.Id + "}, Charge {" + Loan.StandingCharge + "}"
                    };
                    TransactionDescription debitSystemLoanAmount = new TransactionDescription
                    {
                        GUID = Guid.NewGuid().ToString(),
                        CreditAccount = Account,
                        DebitAccount = account,
                        Description = "Loan Gifted , Loan{" + Loan.Id + "}, Amount {" + Loan.Principal + "}"

                    };

                    API.Controllers.TransactionDescription.Create(transDes);
                    transDes = API.Controllers.TransactionDescription.FindByGUID(transDes.GUID);
                    API.Controllers.TransactionDescription.Create(debitSystemLoanAmount);
                    debitSystemLoanAmount = API.Controllers.TransactionDescription.FindByGUID(debitSystemLoanAmount.GUID);

                    CreditDebit debitSys = new CreditDebit
                    {
                        TransactionDescription = debitSystemLoanAmount,
                        Transaction = transaction,
                        Account = account,
                        Debit = (double)Loan.Principal,
                        Credit = 0,
                        TransactionType = Transaction.TransactionTypes.WITHDRAW
                    };
                    API.Controllers.CreditDebit.Create(debitSys);
                  //  API.Message("SystemOut", MessageBoxIcon.Information);

                    CreditDebit credSys = new CreditDebit
                    {
                        TransactionDescription = transDes,
                        Transaction = transaction,
                        Account = API.Controllers.Accounts.FetchByAccountNumber(0),
                        Credit = (double)Loan.StandingCharge,
                        Debit = 0,
                        TransactionType = Transaction.TransactionTypes.STANDING_CHARGE
                    };
                    API.Controllers.CreditDebit.Create(credSys);



                    //deposit the money to account
                    Transaction transactiond = new Transaction { TransationGUId = Guid.NewGuid().ToString(), TransationType = Transaction.TransactionTypes.DEPOSIT };
                    API.Controllers.Transaction.Create(transactiond);
                    transactiond = API.Controllers.Transaction.FindByGUID(transactiond.TransationGUId);
                    TransactionDescription transactionDescription = new TransactionDescription { Description = "Loan Deposit Deposit", GUID = Guid.NewGuid().ToString(), CreditAccount = Account, DebitAccount = account };
                    API.Controllers.TransactionDescription.Create(transactionDescription);
                    transactionDescription = API.Controllers.TransactionDescription.FindByGUID(transactionDescription.GUID);
                    CreditDebit creditDebit = new CreditDebit { Credit = (double)Loan.Principal, Transaction = transactiond, TransactionDescription = transactionDescription, Account = Account, TransactionType = Transaction.TransactionTypes.DEPOSIT };
                    API.Controllers.CreditDebit.Create(creditDebit);




                    API.Message("Standard Charge Successfully", MessageBoxIcon.Information);
                }
                API.Controllers.Loans.UpdateStatus(Loan, cboAction.SelectedIndex + 1);
                API.Message("Updated Successfully", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                API.Message(ex.Message, MessageBoxIcon.Error);
                return;
            }
        }

        private void cboAction_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoanMoreDetails lm = new LoanMoreDetails(Loan);
            lm.ShowDialog();
        }
    }
}
