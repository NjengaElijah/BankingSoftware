using System;

namespace Moshi_Bank.Models
{
    public  class Constrain
    {
        public String Id
        {
            get; set;
        }
        public Account Account
        {
            get; set;
        }
        public Double Amount
        {
            get; set;
        }
        public int Time
        {
            get; set;
        }
    }
}
