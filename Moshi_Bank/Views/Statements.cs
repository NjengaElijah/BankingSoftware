using Moshi_Bank.Models;
using System;
using System.Windows.Forms;

namespace Moshi_Bank.Views
{
    public partial class Statements : Form
    {
        public Statements()
        {
            InitializeComponent();
            cboType.SelectedIndex = 0;
        }

        Account account = null;
        private void btnProcess_Click(object sender , EventArgs e)
        {
            if (account != null)
            {
                if (checkBox1.Checked)
                { 
                    String sDate = dtpStartDate.Text.ToString() + " 23:59:59";
                    String eDate = dtpEndDate.Text.ToString() + " 23:59:59";


                    if (cboType.SelectedIndex == 0)
                    {
                        dgvTransactions.DataSource = Client.database.SelectForDataGridView
                            (
                            "SELECT * FROM  v_account_recent_transaction WHERE `#` = @AccountNumber AND `DateStamp` >= @startDate AND `DateStamp` <= @endDate ;" +
                            "  " ,
                            new Client.SQL().ParameterRange("AccountNumber" , "startDate" , "endDate") ,
                            new Client.SQL().ValuesRange(account.Number , sDate , eDate)
                            );
                    }
                    else
                    {
                        dgvTransactions.DataSource = Client.database.SelectForDataGridView
                            (
                            "SELECT * FROM  v_account_recent_transaction WHERE `#` = @AccountNumber AND `DateStamp` >= @startDate AND `DateStamp` <= @endDate AND `Type Id` = @type;" +
                            "  " ,
                            new Client.SQL().ParameterRange("AccountNumber" , "startDate" , "endDate" , "type") ,
                            new Client.SQL().ValuesRange(account.Number , sDate , eDate , cboType.SelectedIndex)
                            );
                    }
                }
                else
                {
                    dgvTransactions.DataSource = Client.database.SelectForDataGridView
                           (
                           "SELECT * FROM  v_account_recent_transaction WHERE `#` = @AccountNumber " +
                           "  " ,
                           new Client.SQL().ParameterRange("AccountNumber") ,
                           new Client.SQL().ValuesRange(account.Number)
                           );

                }
            }
            else
            {
                API.Message("Select an Account First" , MessageBoxIcon.Error);
            }
        }

        private void findUser1_FoundUser(Account account , User user , object sender , EventArgs e)
        {
            this.account = account;
            txtAccountBalance.Text = "Bal : " + account.Balance + " /= ";
            txtAccountNames.Text = "Acc.Names : " + account.Names.ToUpper();
        }
    }
}
