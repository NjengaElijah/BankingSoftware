using Moshi_Bank.Models;
using System;
using System.Windows.Forms;

namespace Moshi_Bank.Views
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
            API.filter(txtDeposit);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        Models.Account acc = null;
        Constrain constrain = null;
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (acc == null)
            {
                API.Message("Please Search For an Account to Deposit To", MessageBoxIcon.Error);
            }
            else
            {
                double deposit = 0;
                try
                {
                    deposit = Convert.ToDouble(txtDeposit.Text);
                }
                catch
                {
                    API.Message("Please Input A Valid Number", MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    if (MessageBox.Show("Confirm Deposit Of \n" + deposit + " To : {" + acc.Names + " : " + acc.Number + "}", "Deposit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    {
                        Transaction transaction = new Transaction { TransationGUId = Guid.NewGuid().ToString(), TransationType = Transaction.TransactionTypes.DEPOSIT };
                        API.Controllers.Transaction.Create(transaction);
                        transaction = API.Controllers.Transaction.FindByGUID(transaction.TransationGUId);
                        TransactionDescription transactionDescription = new TransactionDescription { Description = "Over the Counter Deposit", GUID = Guid.NewGuid().ToString(), CreditAccount = acc, DebitAccount = acc };
                        API.Controllers.TransactionDescription.Create(transactionDescription);
                        transactionDescription = API.Controllers.TransactionDescription.FindByGUID(transactionDescription.GUID);
                        CreditDebit creditDebit = new CreditDebit { Credit = deposit, Transaction = transaction, TransactionDescription = transactionDescription, Account = acc, TransactionType = Transaction.TransactionTypes.DEPOSIT };
                        API.Controllers.CreditDebit.Create(creditDebit);

                        API.Message("Transaction Successfull", MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    API.Message(ex.Message, MessageBoxIcon.Error);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void findUser1_FoundUser(Account account, User user, object sender, EventArgs e)
        {
            acc = account;
            constrain = API.Controllers.AccountConstrains.FindConstrain(acc);
            lblAccountNames.Text = acc.Names;
            lblBalance.Text = "" + acc.Balance;
            lblDateCreated.Text = DateTime.Parse(acc.DateCreated).ToLongDateString() + " ," + DateTime.Parse(acc.DateCreated).ToLongTimeString();


            txtAccType.Text = account.Type.Name;
            if (account.Type.Type == 0)
            {
                //current
                panel6.Visible = false;
            }
            else if (account.Type.Type == 1)
            {
                //fixedDep
                panel6.Visible = true;
                Constrain constr = API.Controllers.AccountConstrains.FindConstrain(account);
                if (constr != null)
                {
                    datagridFixedDep.Rows.Add(constr.Time, constr.Amount);
                }
            }
            dgvRecentTransactions.DataSource = Client.database.SelectForDataGridView
                           (
                           "SELECT * FROM  v_account_recent_transaction WHERE `#` = @AccountNumber order by `DateStamp` desc LIMIT 5 ;" +
                           "  ",
                           new Client.SQL().ParameterRange("AccountNumber"),
                           new Client.SQL().ValuesRange(account.Number)
                           );


        }

        private void Deposit_Load(object sender, EventArgs e)
        {

        }

        private void txtDeposit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDeposit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                btnDeposit_Click(sender, e);
        }
    }
}
