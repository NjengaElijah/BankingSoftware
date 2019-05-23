using System;
using System.Windows.Forms;

namespace Moshi_Bank.Views
{
    public partial class SearchAccouns : Form
    {
        public SearchAccouns()
        {
            InitializeComponent();
            API.filter(txtNationalId, txtAccountNumber);
        }

        private void AllAccouns_Load(object sender, EventArgs e)
        {
            dgvRecentTransactions.DataSource = Client.database.SelectForDataGridView("SELECT * FROM v_accounts LIMIT 100", null, null);
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnSearchAccountNo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAccountNumber.Text.Trim().Equals(String.Empty))
                {
                    API.Message("Input Account Number", MessageBoxIcon.Asterisk);
                }
                else
                {
                    dgvRecentTransactions.DataSource =
                        Client
                        .database
                        .SelectForDataGridView(
                            "SELECT * FROM v_accounts WHERE `Account No.` = @acc",
                            new Client.SQL().ParameterRange("@acc"),
                            new Client.SQL().ValuesRange(txtAccountNumber.Text));
                }
            }
            catch (Exception ex)
            {
                API.Message(ex.Message, MessageBoxIcon.Asterisk);
                return;
            }
        }

        private void btnSearchNationalId_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtNationalId.Text.Trim().Equals(String.Empty))
                {
                    API.Message("Input Id Number", MessageBoxIcon.Asterisk);
                }
                else
                {
                    dgvRecentTransactions.DataSource =
                    Client
                    .database
                    .SelectForDataGridView(
                        "SELECT * FROM v_accounts WHERE `Nat Id` = @nId",
                        new Client.SQL().ParameterRange("@nId"),
                        new Client.SQL().ValuesRange(txtNationalId.Text));
                }
            }
            catch (Exception ex)
            {
                API.Message(ex.Message, MessageBoxIcon.Asterisk);
                return;
            }
        }

        private void btnSearchAccountNames_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtAccountNamaes.Text.Trim().Equals(String.Empty))
                {
                    API.Message("Input Account Names", MessageBoxIcon.Asterisk);
                }
                else
                {
                    dgvRecentTransactions.DataSource =
                    Client
                    .database
                    .SelectForDataGridView(
                        "SELECT * FROM v_accounts WHERE `Account Names` like '%" + txtAccountNamaes.Text + "%'",
                        null,
                        null);
                }
            }
            catch (Exception ex)
            {
                API.Message(ex.Message, MessageBoxIcon.Asterisk);
                return;
            }
        }

        private void txtAccountNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                btnSearchAccountNo_Click(sender, e);
        }

        private void txtNationalId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                btnSearchNationalId_Click(sender, e);
        }

        private void txtAccountNamaes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                btnSearchAccountNames_Click(sender, e);
        }

        private void dgvRecentTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
