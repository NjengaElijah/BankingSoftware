using System;
using System.Windows.Forms;

namespace Moshi_Bank.Views
{
    public partial class CheckBalance : Form
    {
        public CheckBalance()
        {
            InitializeComponent();
        }

        private void CheckBalance_Load(object sender , EventArgs e)
        {

        }

        private void findUser1_FoundUser(Models.Account account , Models.User user , object sender , EventArgs e)
        {
            lblAccountType.Text = account.Type.Name;
            lblAccountNames.Text = account.Names;
            lblAccountNumber.Text = account.Number;
            lblBalance.Text = "" + account.Balance;
            lblDateCreated.Text = DateTime.Parse(account.DateCreated).ToLongDateString();
        }
    }
}
