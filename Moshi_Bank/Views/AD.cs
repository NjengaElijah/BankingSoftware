using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Moshi_Bank.Views
{
    public partial class AD : Form
    {
        public AD()
        {
            InitializeComponent();
        }
        Models.Account account = new Models.Account();
        private void findUser1_FoundUser(Models.Account account, Models.User user, object sender, EventArgs e)
        {
            if (account != null)
            {
                this.account = account;
                DisplayAccounts();
            }
            else
            {
                API.Message("Search for deactivated accounts from below", MessageBoxIcon.Warning);
            }
        }

        private void DisplayAccounts()
        {
            lblNames.Text = account.Names;
            lblBalance.Text = account.Balance.ToString();
            MySqlDataReader reader = Client.database.NewExecuteQuerry(
                "SELECT sum(credit),sum(debit) FROM cred_deb WHERE AccountNumber = @acc",
                new Client.SQL().ParameterRange("@acc"),
                new Client.SQL().ValuesRange(account.Number)
                );
            while (reader.Read())
            {
                lblCredit.Text = reader[0].ToString();
                lblDebit.Text = reader[1].ToString();
            }
            if (account.isActive)
            {
                btnAD.Text = "Deactivate";
            }
            if (!account.isActive)
            {
                btnAD.Text = "Activate";
            }
            reader.Close();
        }

        private void findUser1_SearchStarted()
        {
        }

        private void btnAD_Click(object sender, EventArgs e)
        {
            try
            {
                String state = "Deactivated";
                if (account != null)
                {
                    if (account.isActive)
                    {
                        state = "Deactivated";
                        API.Controllers.Accounts.Deactivate(account);
                    }
                    else if (!account.isActive)
                    {
                        state = "Activated";
                        API.Controllers.Accounts.Activate(account);
                    }
                }
                API.Message("Account " + state + " Successsfully !!", MessageBoxIcon.Information);
                datagrid1.DataSource = Client.database.SelectForDataGridView("SELECT `Number`,`Names`,`Balance` FROM accounts WHERE `Status` = 2;", null, null);
            }
            catch (Exception ex)
            {
                API.Message(ex.Message, MessageBoxIcon.Error);
                return;
            }
        }

        private void AD_Load(object sender, EventArgs e)
        {
            datagrid1.DataSource = Client.database.SelectForDataGridView("SELECT `Number`,`Names`,`Balance` FROM accounts WHERE `Status` = 2;", null, null);
        }

        private void datagrid1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            account = API.Controllers.Accounts.FetchByAccountNumber(datagrid1[0, e.RowIndex].Value);
            DisplayAccounts();
        }

        private void datagrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            account = API.Controllers.Accounts.FetchByAccountNumber(datagrid1[0, e.RowIndex].Value);
            DisplayAccounts();
        }

        private void title5_Load(object sender, EventArgs e)
        {

        }

        private void title1_Load(object sender, EventArgs e)
        {

        }

        private void datagrid1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            account = API.Controllers.Accounts.FetchByAccountNumber(datagrid1[0, e.RowIndex].Value);
            DisplayAccounts();
        }
    }
}
