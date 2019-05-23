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
    public partial class MainUsers : Form
    {
        public MainUsers()
        {
            InitializeComponent();
        }

        private void MainUsers_Load(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.ShowDialog();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            AllUsers users = new AllUsers();users.ShowDialog();
        }
    }
}
