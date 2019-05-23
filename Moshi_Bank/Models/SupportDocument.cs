using System;

namespace Moshi_Bank.Models
{
    public class SupportDocument
    {
        public String Id { get; set; }
        public String Description { get; set; }
        public byte[] Document { get; set; }
        public Loan Loan { get; set; }
    }
}
