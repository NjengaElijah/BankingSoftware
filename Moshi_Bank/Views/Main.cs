using System;
using System.Windows.Forms;
using Moshi_Bank.Views;
namespace Moshi_Bank
{
    public partial class Main : Form
    {
        Timer t = new Timer();
        public Main()
        {
            InitializeComponent();
            if (API.Staff.Level == 1)
            {
                //staff
                panels1.Visible = false;
                panels2.Visible = false;
                panels4.Visible = false;
                pnlSettings.Visible = false;
            }
            if (API.Staff.Level == 2)
            {
                //manager
                panels2.Visible = true;
                panels4.Visible = true;
                panels1.Visible = true;
                pnlSettings.Visible = true;
            }  
        }

        private void Main_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = API.ImageFromByte(API.Staff.UserPhoto);
            lblE.Text = API.Staff.Email;
            lblN.Text = API.Staff.Names;
            t.Enabled = true;
            t.Interval = 1000;
            t.Tick += T_Tick;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            lblT.Text = DateTime.Now.ToLongDateString() + " , " + DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainUsers users = new MainUsers();
            users.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Accounts acc = new Accounts();
            acc.ShowDialog();

        }

        private void btnCRU_Click(object sender, EventArgs e)
        {
            RandomUsers r = new RandomUsers();
            r.ShowDialog();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            deposit.ShowDialog();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            withdraw.ShowDialog();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            AccountTransactions accountTransactions = new AccountTransactions();
            accountTransactions.ShowDialog();
        }

        private void panels1_ev(object sender, EventArgs e)
        {
            API.Message(this.Name, MessageBoxIcon.Hand);
        }

        private void panels1_Load(object sender, EventArgs e)
        {

        }

        private void panels1_Clicked(object sender, EventArgs e)
        {

        }

        private void pnlCreateUser_Clicked(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void panels1_Load_1(object sender, EventArgs e)
        {

        }

        private void panels1_Click(object sender, EventArgs e)
        {

        }

        private void btnBalances_Click(object sender, EventArgs e)
        {
            CheckBalance checkBalance = new CheckBalance();
            checkBalance.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTransfer_Clicked(object sender, EventArgs e)
        {
            TransferMoney transfer = new TransferMoney();
            transfer.ShowDialog();
        }

        private void pnlTransactions_Clicked(object sender, EventArgs e)
        {
            AccountTransactions accountTransactions = new AccountTransactions();
            accountTransactions.ShowDialog();
        }

        private void pnlStats_Load(object sender, EventArgs e)
        {
        }

        private void pnlStats_Clicked(object sender, EventArgs e)
        {

            Statistics statistics = new Statistics();
            statistics.ShowDialog();
        }

        private void pnlStatements_Clicked(object sender, EventArgs e)
        {
            Statements statements = new Statements();
            statements.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlAccounts_Clicked(object sender, EventArgs e)
        {
            MainAccounts accounts = new MainAccounts();
            accounts.ShowDialog();
        }

        private void pnlAccounts_Load(object sender, EventArgs e)
        {

        }

        private void pnlSettings_Clicked(object sender, EventArgs e)
        {
            MainSettings settings = new MainSettings();
            settings.ShowDialog();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        { 
        }

        private void panels2_Clicked(object sender, EventArgs e)
        {
            AD ad = new AD();
            ad.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            API.Staff = null;
            this.Hide();
            Login lo = new Login();
            lo.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Settings sett = new Settings();
            sett.ShowDialog();
        }

        private void panels3_DoubleClick(object sender, EventArgs e)
        {
            MainLoans loans = new MainLoans(); loans.ShowDialog();
        }

        private void panels4_Click(object sender, EventArgs e)
        {
            MainStaff staff = new MainStaff(); staff.ShowDialog();
        }

        private void panels3_Load(object sender, EventArgs e)
        {

        }
    }
}
