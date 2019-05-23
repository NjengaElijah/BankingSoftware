using System;
using System.Windows.Forms;

namespace Moshi_Bank.Views
{
    public partial class MainSettings : Form
    {
        public MainSettings()
        {
            InitializeComponent();
        }

        private void bunifuTileButton1_Click(object sender , EventArgs e)
        {
            TransactionCharges transactionCharges = new TransactionCharges();
            transactionCharges.ShowDialog();
        }

        private void bunifuTileButton2_Click(object sender , EventArgs e)
        {
            AccountOpeningFee accOpenFee = new AccountOpeningFee();
            accOpenFee.ShowDialog();
        }

        private void bunifuTileButton3_Click(object sender , EventArgs e)
        {
            MainStaff staff = new MainStaff();
            staff.ShowDialog();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            MainLoans loans = new MainLoans();
            loans.ShowDialog();
        }
    }
}
