using System;
using System.Windows.Forms;
using Moshi_Bank.Models;

namespace Moshi_Bank.Views
{
    public partial class SupportDocuments : Form
    {
        SupportDocument doc;
        public SupportDocuments(SupportDocument support)
        {
            InitializeComponent();
            if (doc != null)
            {
                pictureBox1.Image = API.ImageFromByte(doc.Document);
                txtDesi.Text = doc.Description;
            }
            this.doc = support;
        }

        public SupportDocument GetDocumentSupport()
        {
            ShowDialog();
            return doc;
        }
        private void SupportDocuments_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            API.BrowseImage(pictureBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtDesi.Text.Trim().Equals(String.Empty) || pictureBox1.Image == null)
            {
                API.Message("Please make sure you have selected an image and input a description", MessageBoxIcon.Error);
            }
            else
            {
                doc.Description = txtDesi.Text;
                doc.Document = API.ImageToByte(pictureBox1.Image);
                Close();
            }
        }
    }
}
