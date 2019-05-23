using System;

namespace Moshi_Bank.Models
{
    public class TransactionDescription
    {
        public String Id { get; set; }
        public DateTime DateStamp { get; set; }
        public Account CreditAccount { get; set; }
        public Account DebitAccount { get; set; }
        public String GUID { get; set; }
        public String Description { get; set; }
    }
}
