using Moshi_Bank.Models;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Moshi_Bank.Views
{
    public partial class Accounts : Form
    {
        User user = null;
        public Accounts()
        {
            InitializeComponent();
            dgvRelatedAccounts.Visible = false;
            lblNoAccountMessage.Text = "Please search for a user or add one";
            lblNoAccountMessage.ForeColor = Color.SeaGreen;
        }

        private void btnSearch_Click(object sender , EventArgs e)
        {
            dgvRelatedAccounts.Visible = false;
            lblNoAccountMessage.Visible = false;
            dgvRelatedAccounts.Rows.Clear();
            txtPhoneNo.Clear();
            txtUNames.Clear();
            picDS.Image = null;
            picUserPhoto.Image = null;
            if (txtNatId.Text.Trim().Equals(String.Empty))
            {
                API.Message("Please Provide Search Parameters" , MessageBoxIcon.Warning);
            }
            else
            {
                user = API.Controllers.Users.FindByNatinalId(txtNatId.Text);
                if (user != null)
                {
                    MySqlDataReader drAcc = Client.database.executeQuerry("SELECT * FROM accounts WHERE UserId = " + user.Id + "");
                    while (drAcc.Read())
                    {
                        Account acc = new Account
                        {
                            Number = drAcc["Number"].ToString(),
                            Names = drAcc["Names"].ToString(),
                            Balance = Convert.ToDouble(drAcc["Balance"].ToString()),
                            UserId = Convert.ToInt32(drAcc["UserId"].ToString()),
                            Type = new AccountType { Type = (Convert.ToInt32(drAcc["Type"].ToString())) },
                            DateCreated = DateTime.Parse(drAcc["date_stamp"].ToString()).ToLongDateString()
                        };
                        user.Accounts.Add(acc);
                        dgvRelatedAccounts.Rows.Add(acc.Number , acc.Names , acc.Type.Name , acc.Balance , acc.DateCreated);
                    }
                    drAcc.Close();

                    txtNatId.Text = user.NationalId;
                    txtUNames.Text = user.Names;
                    txtPhoneNo.Text = user.Phone;
                    picDS.Image = API.ImageFromByte(user.DigitalSignature);
                    picUserPhoto.Image = API.ImageFromByte(user.UserPhoto);

                    if (user.Accounts == null || user.Accounts.Count == 0)
                    {
                        dgvRelatedAccounts.Visible = false;
                        lblNoAccountMessage.Visible = true;
                        lblNoAccountMessage.Text = "No accounts found from this user";
                        lblNoAccountMessage.ForeColor = Color.Firebrick;
                    }
                    else if (user.Accounts.Count == 3)
                    {
                        dgvRelatedAccounts.Visible = true;
                        API.Message("You Already Have 3 Accounts " , MessageBoxIcon.Information);
                        btnProceedToCreateAccount.Enabled = false;
                    }
                    else
                    {
                        dgvRelatedAccounts.Visible = true;
                        lblNoAccountMessage.Visible = false;
                        btnProceedToCreateAccount.Enabled = true  ;
                    }
                }
                else
                {
                    API.Message("\"0\" Results found for IDNO : " + txtNatId.Text , MessageBoxIcon.Information);
                }
            }
        }

        private void Accounts_Load(object sender , EventArgs e)
        {

        }

        private void linkLblCreateUser_LinkClicked(object sender , LinkLabelLinkClickedEventArgs e)
        {
            Users users = new Users();
            users.ShowDialog();
        }


        private void txtNatId_KeyDown(object sender , KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnSearch_Click(sender , e);
            }
        }

        private void btnProceedToCreateAccount_Click(object sender , EventArgs e)
        {
            if (user == null)
            {
                API.Message("Select a User and Try Again" , MessageBoxIcon.Warning);
            }
            else
            {
                if (cboAccountType.Text.Trim().Equals(String.Empty))
                {
                    API.Message("Please Select Type Of Account" , MessageBoxIcon.Warning);
                }
                else
                {
                    Models.AccountType type = new Models.AccountType { Name = cboAccountType.Text , Type = cboAccountType.SelectedIndex };
                    if (user.Id != null && type != null)
                    {
                        if (type.Type == 0)
                        {
                            CreateAccount createAccount = new CreateAccount(user , type);
                            createAccount.ShowDialog();
                        }
                        else if (type.Type == 1)
                        {
                            FixedDepositAccount createAccount = new FixedDepositAccount(user , type);
                            createAccount.ShowDialog();
                        }
                    }
                    else
                    {
                        API.Message("Failed to proceed Try Again" , MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void cboAccountType_SelectedIndexChanged(object sender , EventArgs e)
        {

        }

        private void gvRelatedAccounts_CellDoubleClick(object sender , DataGridViewCellEventArgs e)
        {
            Account acc = API.Controllers.Accounts.FetchByAccountNumber(dgvRelatedAccounts[0 , e.RowIndex].Value.ToString());
            AccountDetails accDetails = new AccountDetails(acc);
            accDetails.ShowDialog();
        }

    }
}
