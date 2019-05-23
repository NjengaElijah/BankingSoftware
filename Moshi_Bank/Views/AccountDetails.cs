using Moshi_Bank.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Moshi_Bank.Views
{
    public partial class AccountDetails : Form
    {
        Models.User user; Models.Account account;
        public AccountDetails(Models.Account account)
        {
            InitializeComponent();
            this.account = account;
            user = API.Controllers.Users.FindById("" + account.UserId);

            account = API.Controllers.Accounts.FetchByAccountNumber(account.Number);
            initControls(account);
            this.MinimumSize = this.Size;
        }

        private void initControls(Account a)
        {
            txtAccBal.Text = "" + a.Balance;
            txtAccName.Text = a.Names;
            txtAccType.Text = a.Type.Name;
            txtUAddr.Text = user.Address;
            txtUEmail.Text = user.Email;
            txtUN.Text = user.Names;
            txtUNId.Text = user.NationalId;
            txtUP.Text = user.Phone;
            picDS.Image = API.ImageFromByte(user.DigitalSignature);
            picUserPic.Image = API.ImageFromByte(user.UserPhoto);
            txtAccountNumber.Text = "" + account.Number;
            dgvRecentTransactions.DataSource = Client.
                database.
                SelectForDataGridView(
                "SELECT * FROM `v_account_recent_transaction` WHERE `#` = @AccountNumber LIMIT 10; "
                , new List<string>(new String[] { "@AccountNumber" })
                , new List<Object>(new String[] { account.Number }));
            if (dgvRecentTransactions.Rows.Count == 0)
            {
                //No recent Transactions
                dgvRecentTransactions.Visible = false;
                lblNoAccountMessage.Visible = true;
            }
            else
            {
                //Available Recent Transactions
                dgvRecentTransactions.Visible = true;
                lblNoAccountMessage.Visible = false;
            }
            if (a.Type.Type == 1)
            {
                panel6.Visible = true;
                Constrain constrain = API.Controllers.AccountConstrains.FindConstrain(a);
                if (constrain != null)
                {
                    datagridFixedDep.Rows.Add(constrain.Time , constrain.Amount);
                }
            }
            else
            {
                panel6.Visible = false;
            }
        }

        private void AccountDetails_Load(object sender , EventArgs e)
        {

        }
    }
}
