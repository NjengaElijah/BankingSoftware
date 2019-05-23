using System;
using System.Windows.Forms;
namespace Moshi_Bank
{
    public partial class Users : Form
    {
        WebCam w = new WebCam();
        public Users()
        {
            InitializeComponent();
            w.InitializeWebCam(ref picUserPhoto);
            API.filter(txtNationalId , txtNOKNatId , txtNOKPhone , txtPhone);
        }

        private void Users_Load(object sender , EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender , EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender , EventArgs e)
        {

        }

        private void btnCreateUser_Click(object sender , EventArgs e)
        {
            //validate all fields;
            string names, phone, email, address, natid, noknames, nokphone, nokemail, noknatid;
            names = txtNames.Text;
            phone = txtPhone.Text;
            email = txtEmail.Text;
            natid = txtNationalId.Text;
            noknames = txtNOKNames.Text;
            nokphone = txtNOKPhone.Text;
            nokemail = txtNOKEmail.Text;
            noknatid = txtNOKNatId.Text;
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

            if (noknames.Trim().Equals(""))
            {
                error += "\n.NOK Names";
            }

            if (nokphone.Trim().Equals(""))
            {
                error += "\n.NOK Phone";
            }
            else
            {
                try
                {
                    Convert.ToInt32(nokphone);
                }
                catch
                {
                    error += "\n.Invalid NOK Phone";
                }
            }

            if (nokemail.Trim().Equals(""))
            {
                error += "\n.NOK Email";
            }

            if (noknatid.Trim().Equals(""))
            {
                error += "\n.NOK National Id";
            }
            if (picUserPhoto.Image == null)
            {
                error += "\n.User Photo";
            }
            if (picDigitalSignature.Image == null)
            {
                error += "\n.Digital Signature";
            }
            if (error.Trim().Equals(""))
            {
                Models.User user = new Models.User();

                user.Names = names;
                user.Phone = phone;
                user.Email = email;
                user.Address = address;
                user.NationalId = natid;
                user.NOKNames = noknames;
                user.NOKNationalId = noknatid;
                user.NOKEmail = nokemail;
                user.NOKPhone = nokphone;
                user.UserPhoto = API.ImageToByte(picUserPhoto.Image);
                user.DigitalSignature = API.ImageToByte(picDigitalSignature.Image);
                try
                {
                    user.Save();
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


        private void btnStartCamera_Click(object sender , EventArgs e)
        {
            w.Start();
        }

        private void btnBroweImage_Click(object sender , EventArgs e)
        {
            API.BrowseImage(picUserPhoto);
        }

        private void btnBrowseSignature_Click(object sender , EventArgs e)
        {
            API.BrowseImage(picDigitalSignature);
        }

        private void btnStopCamera_Click(object sender , EventArgs e)
        {
            w.Stop();
        }

        private void label10_Click(object sender , EventArgs e)
        {

        }

        private void Users_FormClosing(object sender , FormClosingEventArgs e)
        {
            w.Stop();
        }

    }
}
