using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moshi_Bank.Models;
namespace Moshi_Bank.Views
{
    public partial class Settings : Form
    {
        WebCam webCam = new WebCam();
        public Settings()
        {
            InitializeComponent();
            webCam.InitializeWebCam(ref pictureBox1);
        }
        public Staff Staff = API.Staff;
        private void Settings_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = API.ImageFromByte(Staff.UserPhoto);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            webCam.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            webCam.Stop();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            API.BrowseImage(pictureBox1);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtNewPass.Text.Trim().Equals(String.Empty)
                || txtConfPass.Text.Trim().Equals(String.Empty)
                || txtCurrPass.Text.Trim().Equals(String.Empty))
            {
                API.Message("Please fill App PArameters", MessageBoxIcon.Warning);
            }
            else
            {
                if (API.Staff.Password != API.SelectMd5(txtCurrPass.Text))
                {
                    API.Message("Your Passwords do not Match", MessageBoxIcon.Warning);
                }
                else
                {
                    if (txtConfPass.Text.Equals(txtNewPass.Text))
                    {
                        try
                        {
                            API.Controllers.Staffs.UpdateSettings(
                                                txtNewPass.Text
                                                , API.ImageToByte(pictureBox1.Image)
                                                , API.Staff.Id);
                            API.Message("Updated Successfully!!", MessageBoxIcon.Warning);
                        }
                        catch (Exception ex)
                        {
                            API.Message(ex.Message, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch1.Value == false)
            {
                Pass(true, txtConfPass, txtCurrPass, txtNewPass);
            }
            else if (bunifuiOSSwitch1.Value == true)
            {
                Pass(false, txtConfPass, txtCurrPass, txtNewPass);
            }
        }
        private void Pass(bool show, params TextBox[] collection)
        {
            foreach (TextBox t in collection)
                t.UseSystemPasswordChar = show;
        }

    }
}
