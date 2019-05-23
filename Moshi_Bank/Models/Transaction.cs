using System;

namespace Moshi_Bank.Models
{
    public class Transaction
    {
        public String TransactionId
        {
            get; set;
        }
        public int TransationType
        {
            get; set;
        }
        public String TransationGUId
        {
            get; set;
        }
        public String TransationDate
        {
            get; set;
        }
        public struct TransactionTypes
        {
            public static int DEPOSIT = 1, WITHDRAW = 2, SEND_RECEIVE = 3, SEND_RECEIVE_SEND = 4, SEND_RECEIVE_RECEIVE = 5, TRANSACTION_CHARGE = 6, SYSTEM_DEPOSIT = 7, ACCOUNT_CREATION_FEE = 0, LOAN_PAYMENT = 8, STANDING_CHARGE = 9;
        }
    }
}
