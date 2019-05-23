using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Moshi_Bank.Views
{
    public partial class RandomUsers : Form
    {
        public RandomUsers()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RandomUsers_Load(object sender, EventArgs e)
        {
            Client.database.OpenConnection();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                listBox1.Items.Add(textBox1.Text);
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                listBox2.Items.Add(textBox2.Text);
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                listBox3.Items.Add(textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> ids = new List<int>(new int[] { 3, 4, 2, 5, 0, 8, 3, 6, 9, 1 });

            for (int x = 0; x < listBox1.Items.Count; x++)
            {

                Models.User user = new Models.User();
                String Names = listBox1.Items[new Random().Next(0, 9)].ToString() + " " + listBox2.Items[new Random().Next(0, 9)].ToString();

                string idNo = String.Empty;
                for (int i = 0; i <= 8; i++)
                {
                    for (int p = 0; p <= 10000000; p++)
                    { }
                    idNo += "" + ids[new Random().Next(0, 9)].ToString();
                }
                string phoneNo = "07";
                for (int i = 0; i <= 8; i++)
                {
                    for (int p = 0; p <= 10000000; p++) { }
                    phoneNo += "" + ids[new Random().Next(0, i)].ToString();
                }

                user.Names = Names;
                user.Phone = phoneNo;
                user.Email = Names.ToLower().Trim() + "@" + listBox3.Items[new Random().Next(0, 9)].ToString();
                user.Address = "";
                user.NationalId = idNo;
                user.NOKNames = "";
                user.NOKNationalId = "";
                user.NOKEmail = "";
                user.NOKPhone = "";
                user.UserPhoto = API.ImageToByte(null);
                user.DigitalSignature = API.ImageToByte(null);
                try
                {
                    user.Save();
                    API.ClearFields(this.Controls);

                }
                catch (Exception)
                {
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> ids = new List<int>(new int[] { 3, 4, 2, 5, 0, 8, 3, 6, 9, 1 });

            Models.User user = new Models.User();
            String Names = listBox1.Items[new Random().Next(0, 9)].ToString() + " " + listBox2.Items[new Random().Next(0, 9)].ToString();

            string idNo = String.Empty, phoneNo = String.Empty;
            for (int i = 0; i <= 8; i++)
            {
                for (int p = 0; p <= 10000000; p++) { }
                idNo += "" + ids[new Random(9).Next(0, 9)].ToString();

                phoneNo += "" + ids[new Random(9).Next(0, 9)].ToString();
            }
            API.Message(idNo + " -- " + phoneNo, MessageBoxIcon.Asterisk);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<int> ids = new List<int>(new int[] { 3, 4, 2, 5, 0, 8, 3, 6, 9, 1 }); string idNo = String.Empty;
            for (int j = 0; j < ids.Count; j++)
            {
                int r = new Random().Next(0, 9);

                listBox4.Items.Add(r);
                idNo += "" + ids[r].ToString();
                // 
            }; API.Message(idNo, MessageBoxIcon.Asterisk);
        }
    }
}
