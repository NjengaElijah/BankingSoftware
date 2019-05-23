using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moshi_Bank.Views
{
    public partial class AllUsers : Form
    {
        public AllUsers()
        {
            InitializeComponent();
        }

        private void AllUsers_Load(object sender, EventArgs e)
        {
            try
            {
                lblCount.Text = API.Controllers.Users.Count().ToString();
                comboBox1.SelectedIndex = 0;
            }
            catch
            {
                return;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnNatIdGo_Click(object sender, EventArgs e)
        {
            try
            {
                dgvUserAccounts.DataSource =
                    Client.
                    database.
                    SelectForDataGridView(
                        "SELECT * FROM v_user_accounts WHERE NationalId = @natId;"
                    , new List<string> { "@natId" }, new List<object> { txtNatId.Text });
            }
            catch
            {
                return;
            }
        }

        private void btnNamesGo_Click(object sender, EventArgs e)
        {
            try
            {
                dgvUserAccounts.DataSource =
                Client.
                database.
                SelectForDataGridView(
                    "SELECT * FROM v_user_accounts WHERE `Names`  LIKE '%" + txtNames.Text + "%';"
                , null, null);
            }
            catch
            {
                return;
            }
        }

        private void btnEmailGo_Click(object sender, EventArgs e)
        {

        }

        private void txtNatId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                btnNatIdGo_Click(sender, e);
        }

        private void txtNames_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                btnNamesGo_Click(sender, e);
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                btnEmailGo_Click(sender, e);
        }

        private void dgvUserAccounts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UserAccounts userAccc = new UserAccounts(dgvUserAccounts[0, e.RowIndex].Value.ToString());
            userAccc.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String query = String.Empty;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    //all users
                    query = "SELECT * FROM v_user_accounts;";
                    break;
                case 1:
                    //all users with accounts
                    query = "SELECT * FROM v_user_accounts where `No of Accounts` > 0;";
                    break;
                case 2:
                    //all users without accounts
                    query = "SELECT * FROM v_user_accounts where `No of Accounts` <= 0;";
                    break;
            }
            dgvUserAccounts.DataSource =
                    Client.database.SelectForDataGridView(query, null, null);

        }

        private void dgvUserAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
