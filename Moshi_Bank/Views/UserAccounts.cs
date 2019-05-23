using System;
using Moshi_Bank.Models;
using System.Windows.Forms;

namespace Moshi_Bank.Views
{
    public partial class UserAccounts : Form
    {
        public UserAccounts(String natId)
        {
            InitializeComponent();
            User = API.Controllers.Users.FindByNatinalId(natId);
            if (User != null)
            {
                txtEmail.Text = User.Email;
                txtNames.Text = User.Names.ToUpperInvariant();
                txtNatId.Text = User.NationalId;
                txtDateCreated.Text = User.DateCreated;
                pictureBox1.Image = API.ImageFromByte(User.UserPhoto);
                pictureBox2.Image = API.ImageFromByte(User.DigitalSignature);
                lblCount.Text = API.Controllers.Users.AccountsCount(User.Id).ToString();
                dgvUserAccounts.DataSource =
                    Client.
                    database.
                    SelectForDataGridView(
                    "SELECT acs.Number,acs.`Names`,acs.Balance,att.Description FROM accounts AS acs INNER JOIN account_types AS att ON att.Id = acs.`Type` WHERE acs.UserId = " + User.Id
                    , null
                    , null);
            }
        }
        public User User
        {
            get;
            set;
        }

        private void dgvUserAccounts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Account account = API.Controllers.Accounts.FetchByAccountNumber(dgvUserAccounts[0, e.RowIndex].Value);
                if (account != null)
                {
                    AccountDetails accDetails = new AccountDetails(account);
                    accDetails.ShowDialog();
                }
            }
        }

        private void dgvUserAccounts_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
