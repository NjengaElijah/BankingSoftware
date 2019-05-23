using System;
using System.Windows.Forms;

namespace Moshi_Bank.Views
{
    public partial class MainLoans : Form
    {
        public MainLoans()
        {
            InitializeComponent();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            ApplyLoan applyLoan = new ApplyLoan();
            applyLoan.ShowDialog();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            RepayLoan repayLoan = new RepayLoan();
            repayLoan.ShowDialog();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            ViewLoans viewLoan = new ViewLoans();
            viewLoan.ShowDialog();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            LoanSettings ls = new LoanSettings();
            ls.ShowDialog();
        }

        private void MainLoans_Load(object sender, EventArgs e)
        {
            if (API.Staff.Level == 1)
            {
                //staff
                bunifuTileButton4.Visible = false;
                bunifuTileButton3.Visible = false;
                bunifuTileButton1.Visible = false;
            }
            if (API.Staff.Level == 2)
            {
                //manager
                bunifuTileButton4.Visible = true;
                bunifuTileButton3.Visible = true;
                bunifuTileButton1.Visible = true;
            } 
        }
    }
}
