using System;
using System.Drawing;
using System.Windows.Forms;
using Moshi_Bank.Models;
using MySql.Data.MySqlClient;

namespace Moshi_Bank.Views
{
    public partial class Guarantor : Form
    {
        public Guarantor()
        {
            InitializeComponent();
        }
        public Models.Guarantor GetGuarantor()
        {
            ShowDialog();
            return guarantor;
        }
        private void Guarantor_Load(object sender, EventArgs e)
        {

        }
        Models.Guarantor guarantor = new Models.Guarantor();
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            User user = null;
            dgvRelatedAccounts.Visible = false;
            lblNoAccountMessage.Visible = false;
            dgvRelatedAccounts.Rows.Clear();
            txtPhoneNo.Clear();
            txtUNames.Clear();
            picDS.Image = null;
            picUserPhoto.Image = null;
            if (txtNatId.Text.Trim().Equals(String.Empty))
            {
                API.Message("Please Provide Search Parameters", MessageBoxIcon.Warning);
            }
            else
            {
                user = API.Controllers.Users.FindByNatinalId(txtNatId.Text);
                if (user != null)
                {
                    guarantor.User = user;
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
                        dgvRelatedAccounts.Rows.Add(acc.Number, acc.Names, acc.Type.Name, acc.Balance, acc.DateCreated);
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
                    else
                    {
                        dgvRelatedAccounts.Visible = true;
                        lblNoAccountMessage.Visible = false;
                    }
                }
                else
                {
                    API.Message("\"0\" Results found for IDNO : " + txtNatId.Text, MessageBoxIcon.Information);
                }
            }
        }
    }
}
