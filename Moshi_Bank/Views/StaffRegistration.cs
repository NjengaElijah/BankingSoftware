using System;
using System.Windows.Forms;

namespace Moshi_Bank.Views
{
    public partial class StaffRegistration : Form
    {
        WebCam w = new WebCam();
        public StaffRegistration()
        {
            InitializeComponent();
            w.InitializeWebCam(ref picUserPhoto);
        }

        private void btnStartCamera_Click(object sender , EventArgs e)
        {
            w.Start();
        }

        private void btnStopCamera_Click(object sender , EventArgs e)
        {
            w.Stop();
        }

        private void btnBroweImage_Click(object sender , EventArgs e)
        {
            API.BrowseImage(picUserPhoto);
        }

        private void btnCreateUser_Click(object sender , EventArgs e)
        {
            string names, phone, email, address, natid, np, cp;
            int level;
            names = txtNames.Text;
            phone = txtPhone.Text;
            email = txtEmail.Text;
            natid = txtNationalId.Text;
            np = txtNP.Text;
            cp = txtCP.Text;
            level = comboBox1.SelectedIndex + 1;
            address = txtAddress.Text;
            string error = "";
            if (names.Trim().Equals(""))
            {
                error += "\n.Names";
            }
            if (phone.Trim().Equals(""))
            {
                error += "\n.Phone";
            }
            if (email.Trim().Equals(""))
            {
                error += "\n.Email";
            }
            if (address.Trim().Equals(""))
            {
                error += "\n.Address";
            }
            if (natid.Trim().Equals(""))
            {
                error += "\n.NationalId";
            }
            else
            {
                try
                {
                    Convert.ToInt32(natid);
                }
                catch
                {
                    error += "\n.Invalid NationalId";
                }
            }

            if (np.Trim().Equals(""))
            {
                error += "\n.New Password";
            }

            if (cp.Trim().Equals(""))
            {
                error += "\n.Confirm Password";
            }
            else if (!cp.Equals(np))
            {
                error += "\n.Password Do Not Match";

            }

            if (comboBox1.Text.Trim().Equals(""))
            {
                error += "\n.Select A Level";
            }
            if (picUserPhoto.Image == null)
            {
                error += "\n.User Photo";
            }
            if (error.Trim().Equals(""))
            {
                Models.Staff user = new Models.Staff();

                user.Names = names;
                user.Phone = phone;
                user.Email = email;
                user.Address = address;
                user.NationalId = natid;
                user.Password = cp;
                user.UserPhoto = API.ImageToByte(picUserPhoto.Image);
                try
                {
                    API.Controllers.Staffs.Create(user);
                    API.Message("User Created Successfully !" , MessageBoxIcon.Information);
                    API.ClearFields(this.Controls);

                }
                catch (Exception ex)
                {
                    API.Message(ex.Message , MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                //
                API.Message(error , MessageBoxIcon.Warning);
            }

        }
    }
}
