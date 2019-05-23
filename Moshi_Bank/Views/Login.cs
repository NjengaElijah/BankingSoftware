using Moshi_Bank.Client;
using Moshi_Bank.Models;
using System;
using System.Windows.Forms;

namespace Moshi_Bank.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Staff staff = API.Controllers.Staffs.Login(new Models.Staff { Email = txtEmail.Text, Password = txtPassword.Text });

            if (staff == null)
            {
                API.Message("Failed To LogIn", MessageBoxIcon.Warning);
            }
            else
            {
                API.Staff = staff;
                this.Hide(); Main main = new Main();
                    main.ShowDialog();
               
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                database.OpenConnection();
            }
            catch (Exception ex)
            {
                btnLogin.Enabled = false;
                API.Message("" + ex.Message, MessageBoxIcon.Error);
                return;
            }
        
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.isPassword = false;
            }
            else
            {
                txtPassword.isPassword = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
