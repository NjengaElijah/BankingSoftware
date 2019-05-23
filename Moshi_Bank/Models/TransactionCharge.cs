using System;

namespace Moshi_Bank.Models
{
    public class TransactionCharge
    {
        public Transaction Transaction
        {
            get; set;
        }
        public TransactionDescription TransactionDescription
        {
            get; set;
        }
        public int Id
        {
            get; set;
        }
        public int TransactionType
        {
            get; set;
        }
        public Double MinValue
        {
            get; set;
        }
        public Double MaxValue
        {
            get; set;
        }
        public Double Percentage
        {
            get; set;
        }
        public Double Charge
        {
            get; set;
        }
        public DateTime DateStamp
        {
            get; set;
        }
        public int LogId
        {
            get; set;
        }
        public bool Similar(TransactionCharge that)
        {
            if (this.MaxValue == that.MaxValue && this.MinValue == that.MinValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
