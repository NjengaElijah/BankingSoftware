using System;
using System.Windows.Forms;
using Moshi_Bank.Models;
namespace Moshi_Bank.Views
{
    public partial class CreateAccount : Form
    {
        Fee fee;
        User User;
        AccountType AccountType;
        public CreateAccount(User user, AccountType type)
        {
            InitializeComponent();
            this.User = user;
            this.AccountType = type;
            API.filter(txtDepositAmount,txtPIN);
        }
        private void CreateAccount_Load(object sender, EventArgs e)
        {
            InitControls();
        }
        private void InitControls()
        {
            fee = API.Controllers.Fees.FindByAccountType(0);
            if (fee != null)
            {
                label11.Text = fee.Amount.ToString();
            }
            txtAccNames.Text = User.Names;
            txtUAddress.Text = User.Address;
            txtUEmail.Text = User.Email;
            txtUPhone.Text = User.Phone;
            txtUNames.Text = User.Names;
            lblAccountType.Text = AccountType.Name;
            picUser.Image = API.ImageFromByte(User.UserPhoto);
        }
        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (txtDepositAmount.Text.Trim().Equals(String.Empty) || txtAccNames.Text.Trim().Equals(String.Empty))
            {
                API.Message("Input all Parameters", MessageBoxIcon.Warning);
            }
            else if (Convert.ToDouble(txtDepositAmount.Text) < fee.Amount)
            {
                API.Message("You Have to Pay Opening Account Fee", MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Account account = new Account
                    {
                        Names = txtAccNames.Text,
                        Balance = 0.0,
                        Type = AccountType,
                        UserId = Convert.ToInt32(User.Id),PIN  = txtPIN.Text
                    };
                    API.Controllers.Accounts.CreateAccount(account);
                    account = API.Controllers.Accounts.FetchNewUserAccount(Convert.ToInt32(User.Id), account.Names);
                    API.Message(account.Names, MessageBoxIcon.Warning);
                    Account systemAcc = API.Controllers.Accounts.FetchByAccountNumber(0);


                    Transaction Transaction = new Transaction
                    {
                        TransationGUId = Guid.NewGuid().ToString(),
                        TransationType = Transaction.TransactionTypes.DEPOSIT
                    };

                    TransactionDescription TransactionDescription = new TransactionDescription
                    {
                        Description = "First Deposit",
                        CreditAccount = account,
                        DebitAccount = account,
                        GUID = Guid.NewGuid().ToString()
                    };

                    CreditDebit CreditDebit = new CreditDebit
                    {
                        Account = account,
                        PrevBalance = 0.0,
                        Credit = Convert.ToDouble(txtDepositAmount.Text) - fee.Amount,
                        Transaction = Transaction,
                        TransactionDescription = TransactionDescription,
                        TransactionType = Models.Transaction.TransactionTypes.DEPOSIT

                    };



                    TransactionDescription TransactionOpeningFeeDescription = new TransactionDescription
                    {
                        Description = "Opening Fee : " + fee.Amount,
                        CreditAccount = systemAcc,
                        DebitAccount = account,
                        GUID = Guid.NewGuid().ToString()
                    };

                    CreditDebit creditFee = new CreditDebit
                    {
                        Account = systemAcc,
                        Credit = fee.Amount,
                        Transaction = Transaction,
                        TransactionDescription = TransactionOpeningFeeDescription,
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


                        API.Message("Transaction Processed Successfully", MessageBoxIcon.Information);
                        API.ClearFields(this.Controls);

                        AccountDetails AccDetails = new AccountDetails(account);
                        AccDetails.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        API.Message(ex.Message, MessageBoxIcon.Error);
                        return;
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
