using System;
using System.Windows.Forms;
using Moshi_Bank.Models;
namespace Moshi_Bank.Views
{
    public partial class TransferMoney : Form
    {
        public TransferMoney()
        {
            InitializeComponent();
            API.filter(txtTransactionAmount);
        }
        Account sourceAccount = null;
        Account destinationAccount = null;
        private void findUserSource_FoundUser(Account account , Models.User user , object sender , EventArgs e)
        {
            sourceAccount = account;
            txtSourceAccBalance.Text = "" + sourceAccount.Balance;
            txtSourceAccNames.Text = sourceAccount.Names;
            txtSourceAccNumber.Text = sourceAccount.Number;
        }

        private void findUserDestination_FoundUser(Account account , Models.User user , object sender , EventArgs e)
        {
            destinationAccount = account;
            txtDestinationAccNames.Text = destinationAccount.Names;
            txtDestinationAccNumber.Text = destinationAccount.Number;
        }

        private void btnProcessTransaction_Click(object sender, EventArgs e)
        {
            if (sourceAccount != null && destinationAccount != null)
            {
                if (sourceAccount.Number.Equals(destinationAccount.Number))
                {
                    API.Message("Source And Destination Accounts Should Not Be the same".ToUpper(), MessageBoxIcon.Error);
                }
                else if (sourceAccount == null || destinationAccount == null)
                {
                    API.Message("Source And Destination Accounts Should be selected".ToUpper(), MessageBoxIcon.Error);
                }
                else if (txtTransactionAmount.Text.Trim().Equals(String.Empty))
                {
                    API.Message("Input Transaction Amount".ToUpper(), MessageBoxIcon.Error);
                }
                else
                { 
                    if (sourceAccount.PIN != API.SelectMd5(txtSenderAccPin.Text))
                    {
                        API.Message("Failed to Transact.Incorrect Account PIN", MessageBoxIcon.Error);
                    }
                    else
                    {
                        double amount = 0, charge = 0;
                        try
                        {
                            amount = Convert.ToDouble(txtTransactionAmount.Text);
                        }
                        catch
                        {
                            return;
                        }
                        TransactionCharge transactionCharge = API.Controllers.TransactionCharges.FindByValue(amount, Transaction.TransactionTypes.SEND_RECEIVE);
                        if (transactionCharge != null)
                        {

                            switch (API.Controllers.Settings.GetChargingSystem())
                            {
                                case 1:
                                    //values system
                                    charge = transactionCharge.Charge;
                                    break;
                                case 2:
                                    charge = (transactionCharge.Percentage / 100) * amount;
                                    break;
                            }
                            if (amount == 0)
                            {
                                API.Message("You cannot transfer 0.", MessageBoxIcon.Warning);
                            }
                            else if (sourceAccount.Balance < (amount + charge))
                            {
                                API.Message("You cannot transfer more than you have\nYou Have to Pay for the charge too ." + charge, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                //Lets begin the transaction

                                try
                                {
                                    Account SysAcc = API.Controllers.Accounts.FetchByAccountNumber(0);
                                    if (SysAcc != null)
                                    {

                                        Transaction transaction = new Transaction
                                        {
                                            TransationType = Transaction.TransactionTypes.SEND_RECEIVE,
                                            TransationGUId = Guid.NewGuid().ToString()
                                        };
                                        API.Controllers.Transaction.Create(transaction);
                                        transaction = API.Controllers.Transaction.FindByGUID(transaction.TransationGUId);


                                        TransactionDescription sendMoneyDescription = new TransactionDescription
                                        {
                                            CreditAccount = destinationAccount,
                                            DebitAccount = sourceAccount,
                                            GUID = Guid.NewGuid().ToString(),
                                            Description = "Funds Sent to Account Number :  " + destinationAccount.Number + " Account Names : " + destinationAccount.Names + " Amount : " + amount + " , Transaction Charge : " + charge,
                                        };
                                        API.Controllers.TransactionDescription.Create(sendMoneyDescription);
                                        sendMoneyDescription = API.Controllers.TransactionDescription.FindByGUID(sendMoneyDescription.GUID);

                                        TransactionDescription receiveMoneyDescription = new TransactionDescription
                                        {
                                            CreditAccount = destinationAccount,
                                            DebitAccount = sourceAccount,
                                            GUID = Guid.NewGuid().ToString(),
                                            Description = "Funds Received from Account Number :  " + sourceAccount.Number + " Account Names : " + sourceAccount.Names + " Amount : " + amount,

                                        };
                                        API.Controllers.TransactionDescription.Create(receiveMoneyDescription);
                                        receiveMoneyDescription = API.Controllers.TransactionDescription.FindByGUID(receiveMoneyDescription.GUID);

                                        TransactionDescription transactionChargesDesc = new TransactionDescription
                                        {
                                            Description = "Money Transfer , Transaction Charge : " + charge,
                                            GUID = Guid.NewGuid().ToString(),
                                            CreditAccount = SysAcc,
                                            DebitAccount = sourceAccount
                                        };
                                        API.Controllers.TransactionDescription.Create(transactionChargesDesc);
                                        transactionChargesDesc = API.Controllers.TransactionDescription.FindByGUID(transactionChargesDesc.GUID);


                                        CreditDebit sourceDebit = new CreditDebit
                                        {
                                            Account = sourceAccount,
                                            TransactionDescription = sendMoneyDescription,
                                            TransactionType = Transaction.TransactionTypes.SEND_RECEIVE_SEND,
                                            Transaction = transaction,
                                            Credit = 0,
                                            Debit = amount + charge,
                                        };
                                        CreditDebit destinationDebit = new CreditDebit
                                        {
                                            Account = destinationAccount,
                                            TransactionDescription = receiveMoneyDescription,
                                            TransactionType = Transaction.TransactionTypes.SEND_RECEIVE_RECEIVE,
                                            Transaction = transaction,
                                            Credit = amount,
                                            Debit = 0,
                                        };

                                        CreditDebit creditSysAcc = new CreditDebit
                                        {
                                            Credit = charge,
                                            Transaction = transaction,
                                            Account = SysAcc,
                                            TransactionDescription = transactionChargesDesc,
                                            TransactionType = Transaction.TransactionTypes.SYSTEM_DEPOSIT
                                        };


                                        API.Controllers.CreditDebit.Create(sourceDebit);
                                        API.Controllers.CreditDebit.Create(destinationDebit);
                                        API.Controllers.CreditDebit.Create(creditSysAcc);

                                        API.Message("Transaction Successfull !", MessageBoxIcon.Information);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    API.Message("Error : " + ex.Message, MessageBoxIcon.Information);
                                    return;
                                }
                            }
                        }
                        else
                        {
                            API.Message("Failed to Transact.No charges defined.Please contact administrator or manager", MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void TransferMoney_Load(object sender , EventArgs e)
        {

        }

        private void txtSenderAccPin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
