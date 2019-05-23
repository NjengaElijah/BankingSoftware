using System;
using System.Windows.Forms;

namespace Moshi_Bank.Views
{
    partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 5;
            }
            else
            {
                timer1.Stop();
                this.Hide();
                Login l = new Login();
                l.ShowDialog();
            }
        }
    }
}
