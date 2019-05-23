using System;
using System.Windows.Forms;
using Moshi_Bank.Models;
using MySql.Data.MySqlClient;
namespace Moshi_Bank.Controls
{
    public partial class FindUser : UserControl
    {
        public delegate void FindUserEvents(Account account, User user, object sender, EventArgs e);
        public delegate void SearchStartedEvents();
        public event FindUserEvents FoundUser;
        public event SearchStartedEvents SearchStarted;
        public FindUser()
        {
            InitializeComponent();
            txtAccountNumber.KeyDown += TxtAccountNumber_KeyDown; API.filter(txtAccountNumber);
        }

        private void TxtAccountNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnSearchAccount_Click(sender, e);
            }
        }

        public MySqlConnection Connection
        {
            get;
            set;
        }
        public Account Account
        {
            get;
            set;
        }
        public User User
        {
            get;
            set;
        }
        public Boolean AdvancedFind
        {
            get
            {
                return linkLabel1.Visible;
            }
            set
            {
                linkLabel1.Visible = value;
            }
        }
        public void SearchUser(String AccountNumber)
        {
            if (SearchStarted != null)
                SearchStarted();
            try
            {
                if (AccountNumber.Trim().Equals(String.Empty))
                {
                    API.Message("Input Account Number!!", MessageBoxIcon.Error);
                }
                else
                {
                    Account = API.Controllers.Accounts.FetchByAccountNumber(AccountNumber);
                    if (Account != null)
                    {
                        User = API.Controllers.Users.FindById(Convert.ToString(Account.UserId));
                        if (User != null)
                        {
                            picDS.Image = API.ImageFromByte(User.DigitalSignature);
                            picUserPhoto.Image = API.ImageFromByte(User.UserPhoto);
                            txtAccNames.Text = User.Names.ToUpper();
                            lblNationalId.Text = User.NationalId.ToUpper();
                            if (FoundUser != null)
                                FoundUser(Account, User, null, null);
                        }
                        else
                        {
                            API.Message("Fatal Error : Parent User Not Found!!", MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        API.Message("Account Not Found!!", MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                API.Message(ex.Message, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnSearchAccount_Click(object sender, EventArgs e)
        {
            if (SearchStarted != null)
                SearchStarted();
            try
            {
                if (txtAccountNumber.Text.Trim().Equals(String.Empty))
                {
                    API.Message("Input Account Number!!", MessageBoxIcon.Error);
                }
                else
                {
                    Account = API.Controllers.Accounts.FetchByAccountNumber(txtAccountNumber.Text);
                    if (Account != null)
                    {
                        User = API.Controllers.Users.FindById(Convert.ToString(Account.UserId));
                        if (User != null)
                        {
                            picDS.Image = API.ImageFromByte(User.DigitalSignature);
                            picUserPhoto.Image = API.ImageFromByte(User.UserPhoto);
                            txtAccNames.Text = User.Names.ToUpper();
                            lblNationalId.Text = User.NationalId.ToUpper();
                            if (Account.isActive)
                            {
                                if (FoundUser != null)
                                    FoundUser(Account, User, sender, e);
                            }
                            else if (!Account.isActive)
                            {
                                API.Message("This is a Deactivated Account..", MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            API.Message("Fatal Error : Parent User Not Found!!", MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        API.Message("Account Not Found!!", MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                API.Message(ex.Message, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
