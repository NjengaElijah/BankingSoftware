using System;
using System.Collections.Generic;

namespace Moshi_Bank.Models
{
    public class Loan
    {
        public String GUID { get; set; }
        public String Id { get; set; }
        public String Description { get; set; }
        public Account Account { get; set; }
        public int Status { get; set; }
        public Decimal Principal { get; set; }
        public Decimal Interest { get; set; }
        public Decimal Rate { get; set; }
        public Decimal Amount { get; set; }
        public int Time { get; set; }
        public Decimal MonthlyAmount { get; set; }
        public Decimal Balance { get; set; }
        public Decimal StandingCharge { get; set; }
        public DateTime DateApplied { get; set; }
        public List<SupportDocument> SupportDocuments { get; set; }
        public List<Guarantor> Guarantors { get; set; }
        public static class STATUS
        {
            public static int
                PENDING = 1, APPROVED = 2, REJECTED = 3, COMPLETE = 4, INCOMPLETE = 5, CRITICAL = 6;
        }
    }
}
