using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moshi_Bank.Views
{
    public partial class MainStaff : Form
    {
        public MainStaff()
        {
            InitializeComponent();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            StaffRegistration sr = new StaffRegistration();
            sr.ShowDialog();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            AllStaff sr = new AllStaff();
            sr.ShowDialog();
        }
    }
}
