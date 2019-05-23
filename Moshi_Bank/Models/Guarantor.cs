using System;

namespace Moshi_Bank.Models
{
    public class Guarantor
    {
        public String Id { get; set; }
        public Loan Loan { get; set; }

        public User User { get; set; }


    }
}
