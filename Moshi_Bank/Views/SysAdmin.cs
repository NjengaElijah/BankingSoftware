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
    public partial class SysAdmin : Form
    {
        public SysAdmin()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label5.Text.Equals("/"))
            {
                label5.Text = "\\";
            }
          else  if (label5.Text.Equals("\\"))
            {
                label5.Text = "/";
            }
        }
    }
}
