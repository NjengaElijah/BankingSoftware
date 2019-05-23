using System;
using System.Windows.Forms;
using Moshi_Bank.Models;

namespace Moshi_Bank.Views
{
    public partial class FixedDepositAccount : Form
    {
        public FixedDepositAccount(User user , AccountType type)
        {
            InitializeComponent(); API.filter(txtPIN, txtDepositAmount);
            this.User = user;
            this.AccountType = type;
        }
        public User User
        {
            get; set;
        }
        public AccountType AccountType
        {
            get; set;
        }
        Fee fee;
        private void FixedDepositAccount_Load(object sender , EventArgs e)
        {
            InitControls();
        }
        private void InitControls()
        {
            fee = API.Controllers.Fees.FindByAccountType(1);
            if (fee != null)
            {
                lblFee.Text = fee.Amount.ToString();
            }
            txtAccNames.Text = User.Names;
            txtUAddress.Text = User.Address;
            txtUEmail.Text = User.Email;
            txtUPhone.Text = User.Phone;
            txtUNames.Text = User.Names;
            lblAccountType.Text = AccountType.Name;
            picUser.Image = API.ImageFromByte(User.UserPhoto);
        }

        private void btnProceed_Click(object sender , EventArgs e)
        {
            if (txtDepositAmount.Text.Trim().Equals(String.Empty))
            {

            }
            else if (Convert.ToDouble(txtDepositAmount.Text) < fee.Amount)
            {
                API.Message("You Have to Pay Opening Account Fee" , MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Account account = new Account
                    {
                        Names = txtAccNames.Text,
                        PIN = txtPIN.Text,
                        Balance = 0.0 ,
                        Type = AccountType ,
                        UserId = Convert.ToInt32(User.Id)
                    };
                    API.Controllers.Accounts.CreateAccount(account);
                    account = API.Controllers.Accounts.FetchNewUserAccount(Convert.ToInt32(User.Id) , account.Names);


                    //process the deposit transaction
                    //1.create a Transaction Object with Unique GUID
                    //2.Create a TransactionDescription with unique GUID
                    //3.Create a CreditDebit Object 
                    //{use the Transaction.GUID to find the Transaction.Id and 
                    //The TransactionDescription GUID to find the TransactionDescription.Id }


                    Constrain constrain = new Constrain
                    {
                        Account = account ,
                        Amount = Convert.ToDouble(textBox2.Text) ,
                        Time = getTimeRangeFromIndex(comboBox1.SelectedIndex)
                    };
                    API.Controllers.AccountConstrains.Create(constrain);
                    Transaction Transaction = new Transaction
                    {
                        TransationGUId = Guid.NewGuid().ToString() ,
                        TransationType = Transaction.TransactionTypes.DEPOSIT
                    };

                    TransactionDescription TransactionDescription = new TransactionDescription
                    {
                        Description = "First Deposit" ,
                        CreditAccount = account ,
                        DebitAccount = account ,
                        GUID = Guid.NewGuid().ToString()
                    };

                    CreditDebit CreditDebit = new CreditDebit
                    {
                        Account = account ,
                        PrevBalance = 0.0 ,
                        Credit = Convert.ToDouble(txtDepositAmount.Text) - fee.Amount ,
                        Transaction = Transaction ,
                        TransactionDescription = TransactionDescription ,
                        TransactionType = Models.Transaction.TransactionTypes.DEPOSIT

                    };


                    Account systemAcc = API.Controllers.Accounts.FetchByAccountNumber(0);


                    TransactionDescription TransactionOpeningFeeDescription = new TransactionDescription
                    {
                        Description = "Opening Fee : " + fee.Amount ,
                        CreditAccount = systemAcc ,
                        DebitAccount = account ,
                        GUID = Guid.NewGuid().ToString()
                    };

                    CreditDebit creditFee = new CreditDebit
                    {
                        Account = systemAcc ,
                        Credit = fee.Amount ,
                        Transaction = Transaction ,
                        TransactionDescription = TransactionOpeningFeeDescription ,
                        TransactionType = Models.Transaction.TransactionTypes.ACCOUNT_CREATION_FEE
                    };


                    try
                    {

                        API.Controllers.Transaction.Create(Transaction);
                        Transaction = API.Controllers.Transaction.FindByGUID(Transaction.TransationGUId);
                        CreditDebit.Transaction = Transaction;
                        creditFee.Transaction = Transaction;


                        API.Controllers.TransactionDescription.Create(TransactionOpeningFeeDescription);
                        TransactionOpeningFeeDescription = API.Controllers.TransactionDescription.FindByGUID(TransactionOpeningFeeDescription.GUID);
                        creditFee.TransactionDescription = TransactionOpeningFeeDescription;

                        API.Controllers.TransactionDescription.Create(TransactionDescription);
                        TransactionDescription = API.Controllers.TransactionDescription.FindByGUID(TransactionDescription.GUID);
                        CreditDebit.TransactionDescription = TransactionDescription;


                        API.Controllers.CreditDebit.Create(CreditDebit);
                        API.Controllers.CreditDebit.Create(creditFee);
                        CreditDebit = API.Controllers.CreditDebit.FindByTransactionId(Transaction.TransactionId);

                        API.Message("Transaction Processed Successfully" , MessageBoxIcon.Information);


                        AccountDetails AccDetails = new AccountDetails(account);
                        AccDetails.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        API.Message(ex.Message , MessageBoxIcon.Error);
                        return;
                    }

                }
                catch (Exception ex)
                {
                    API.Message(ex.Message , MessageBoxIcon.Error);
                    return;
                }
            }
        }


        public int getTimeRangeFromIndex(int index)
        {
            return new int[] { 2 , 3 , 4 , 5 , 6 , 7 , 8 , 9 , 12 }[index];
        }


    }
}
