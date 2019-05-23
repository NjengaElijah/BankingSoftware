using Moshi_Bank.Models;
using System;
using System.Windows.Forms;

namespace Moshi_Bank.Views
{
    public partial class AccountTransactions : Form
    {
        public AccountTransactions()
        {
            InitializeComponent();
            API.filter(txtAccountNumber);
            API.filter(txtTransactionCode);
        }

        private void AccountTransactions_Load(object sender , EventArgs e)
        {

        }

        private void btnSearchTransactions_Click(object sender , EventArgs e)
        {
            if (txtAccountNumber.Text.Trim().Equals(String.Empty))
            {
                API.Message("Input Account Number !!" , MessageBoxIcon.Error);
            }
            else
            {

                Account acc = API.Controllers.Accounts.FetchByAccountNumber(txtAccountNumber.Text);
                if (acc != null)
                {
                    lblAccountBalance.Text = acc.Balance + "";
                    lblAccountNames.Text = acc.Names;
                    dgvTransactions.DataSource = Client.database.SelectForDataGridView("SELECT * FROM `v_account_recent_transaction` WHERE `#` = @AccountNumber" , new Client.SQL().ParameterRange("@AccountNumber") , new Client.SQL().ValuesRange(acc.Number));

                }
                else
                {
                    API.Message("Account Not Found !!" , MessageBoxIcon.Error);
                    lblAccountBalance.Text = "";
                    lblAccountNames.Text = "";
                    dgvTransactions.DataSource = null;

                }
            }
        }

        private void btnSearchTransactionCode_Click(object sender , EventArgs e)
        {
            txtAccountNumber.Clear();
            lblAccountBalance.Text = String.Empty;
            lblAccountNames.Text = String.Empty;
            if (txtTransactionCode.Text.Trim().Equals(String.Empty))
            {
                API.Message("Input Transaction Code .." , MessageBoxIcon.Warning);
                dgvTransactions.DataSource = null;
            }
            else
            {
                dgvTransactions.DataSource = Client.database.SelectForDataGridView("SELECT * FROM `v_account_recent_transaction` WHERE `Code` = @Code" , new Client.SQL().ParameterRange("@Code") , new Client.SQL().ValuesRange(txtTransactionCode.Text));
            }
        }

        private void txtTransactionCode_KeyPress(object sender , KeyPressEventArgs e)
        {
        }

        private void txtTransactionCode_KeyDown(object sender , KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnSearchTransactionCode_Click(sender , e);
            }
        }

        private void txtAccountNumber_KeyDown(object sender , KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnSearchTransactions_Click(sender , e);
            }
        }

        private void dgvTransactions_CellDoubleClick(object sender , DataGridViewCellEventArgs e)
        {
            Account acc = API.Controllers.Accounts.FetchByAccountNumber(dgvTransactions[0 , e.RowIndex].Value.ToString());
            if (acc != null)
            {
                AccountDetails accountDetails = new AccountDetails(acc);
                accountDetails.ShowDialog();
            }
        }
    }
}
