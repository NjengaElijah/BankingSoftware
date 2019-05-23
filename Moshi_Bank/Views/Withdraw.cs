using Moshi_Bank.Models;
using System;
using System.Windows.Forms;

namespace Moshi_Bank.Views
{
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
            API.filter(txtWithdraw);
            panel6.Visible = false;
        }
        Account acc = null;


        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (acc == null)
            {
                API.Message("Please Search For an Account to Withdraw From", MessageBoxIcon.Error);
            }
            else
            {
                double withdraw = 0, charge = 0;
                try
                {
                    withdraw = Convert.ToDouble(txtWithdraw.Text);
                }
                catch
                {
                    API.Message("Please Input A Valid Number", MessageBoxIcon.Error);
                    return;
                }


                TransactionCharge transactionCharge = API.Controllers.TransactionCharges.FindByValue(withdraw, Transaction.TransactionTypes.WITHDRAW);
                
                if (transactionCharge != null)
                {

                    switch (API.Controllers.Settings.GetChargingSystem())
                    {
                        case 1:
                            //values system
                            charge = transactionCharge.Charge;
                            break;
                        case 2:
                            charge = (transactionCharge.Percentage / 100) * withdraw;
                            break;
                    }

                    if ((withdraw + charge) > acc.Balance)
                    {
                        API.Message("Please Input A Valid Amount.\nYou Cannot Withdraw More Than You Have\nYou Have to Pay for the charge too ." + charge, MessageBoxIcon.Error);
                    }
                    else
                    {

                        if (MessageBox.Show("Confirm Withdrawal Of \n" + withdraw + " + " + charge + "   From : {" + acc.Names + " : " + acc.Number + "}", "Withdraw", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            try
                            {


                                Account SysAcc = API.Controllers.Accounts.FetchByAccountNumber("0");

                                Transaction transaction = new Transaction { TransationGUId = Guid.NewGuid().ToString(), TransationType = Transaction.TransactionTypes.WITHDRAW };
                                API.Controllers.Transaction.Create(transaction);
                                transaction = API.Controllers.Transaction.FindByGUID(transaction.TransationGUId);

                                TransactionDescription transactionDescription = new TransactionDescription { Description = "Over the Counter Withdrawal :  " + withdraw + ", Transaction Charge : " + charge, GUID = Guid.NewGuid().ToString(), CreditAccount = acc, DebitAccount = acc };
                                API.Controllers.TransactionDescription.Create(transactionDescription);
                                transactionDescription = API.Controllers.TransactionDescription.FindByGUID(transactionDescription.GUID);

                                TransactionDescription transactionChargesDesc = new TransactionDescription { Description = "Withdraw , Transaction Charge : " + charge, GUID = Guid.NewGuid().ToString(), CreditAccount = SysAcc, DebitAccount = acc };
                                API.Controllers.TransactionDescription.Create(transactionChargesDesc);
                                transactionChargesDesc = API.Controllers.TransactionDescription.FindByGUID(transactionChargesDesc.GUID);

                                CreditDebit creditDebit = new CreditDebit { Debit = withdraw + charge, Transaction = transaction, TransactionDescription = transactionDescription, Account = acc, TransactionType = Transaction.TransactionTypes.WITHDRAW };
                                API.Controllers.CreditDebit.Create(creditDebit);

                                CreditDebit creditSys = new CreditDebit { Credit = charge, Transaction = transaction, Account = SysAcc, TransactionDescription = transactionChargesDesc, TransactionType = Transaction.TransactionTypes.SYSTEM_DEPOSIT };
                                API.Controllers.CreditDebit.Create(creditSys);


                                API.Message("Transaction Successfull", MessageBoxIcon.Information);

                            }
                            catch (Exception ex)
                            {
                                API.Message(ex.Message, MessageBoxIcon.Error);
                                return;
                            }
                    }
                }
                else
                {
                    API.Message("Failed to transact.No charges defined.Please contact administrator or manager", MessageBoxIcon.Error);
                }
            }
        }

        private void findUser1_FoundUser(Account account, User user, object sender, EventArgs e)
        {
            datagridFixedDep.Rows.Clear();
            acc = account;
            lblAccountNames.Text = acc.Names;
            lblBalance.Text = "" + acc.Balance;
            lblDateCreated.Text = DateTime.Parse(acc.DateCreated).ToLongDateString() + " ," + DateTime.Parse(acc.DateCreated).ToLongTimeString();
            txtAccType.Text = account.Type.Name;
            if (account.Type.Type == 0)
            {
                //current
                panel6.Visible = false;
            }
            else if (account.Type.Type == 1)
            {
                //fixedDep
                panel6.Visible = true;
                Constrain constrain = API.Controllers.AccountConstrains.FindConstrain(account);
                if (constrain != null)
                {
                    datagridFixedDep.Rows.Add(constrain.Time, constrain.Amount);
                }
            }
            dgvRecentTransactions.DataSource = Client.database.SelectForDataGridView
                           (
                           "SELECT * FROM  v_account_recent_transaction WHERE `#` = @AccountNumber order by `DateStamp` desc LIMIT 5 ;" +
                           "  ",
                           new Client.SQL().ParameterRange("AccountNumber"),
                           new Client.SQL().ValuesRange(account.Number)
                           );
        }

        private void txtWithdraw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                btnWithdraw_Click(sender, e);
        }
    }
}
