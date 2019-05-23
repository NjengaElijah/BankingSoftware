using System;
using System.Windows.Forms;

namespace Moshi_Bank.Views
{
    public partial class MainAccounts : Form
    {
        public MainAccounts()
        {
            InitializeComponent();
        }

        private void btnNewAccounts_Click(object sender , EventArgs e)
        {
            Accounts acc = new Accounts();
            acc.ShowDialog();
        }

        private void btnBalances_Click(object sender , EventArgs e)
        {
            CheckBalance chk = new CheckBalance();
            chk.ShowDialog();
        }

        private void btnSearch_Click(object sender , EventArgs e)
        {
            SearchAccouns all = new SearchAccouns();
            all.ShowDialog();
        }
        private void btnStatements_Click(object sender , EventArgs e)
        {
            Statements statements = new Statements();
            statements.ShowDialog();
        }
    }
}
