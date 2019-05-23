using System;

namespace Moshi_Bank.Models
{
    public class SimpleInterest
    {
        public delegate void SimpleInterestEvent(params object[] data);
        public event SimpleInterestEvent DataChanged;
        public SimpleInterest()
        {
           
        }
        public SimpleInterest(Decimal Principal, Decimal Rate, int Time, Decimal StandingCharge)
        {
            this.Principal = Principal; this.Rate = Rate; this.Time = Time; this.StandingCharge = StandingCharge;
        }
        public void Calculate()
        {
            this.Interest = Math.Round(Principal * Rate / 100 * Time / 12, 2);

            Amount = Math.Round(Interest + Principal, 8);

            MonthlyStandingCharge = Math.Round(StandingCharge / Time, 2);

            MonthlyInterest = Math.Round(Interest / Time, 2);

            MonthlyAmount = Math.Round(Amount / Time, 2);
            if (DataChanged != null)
                DataChanged(Interest, Amount, Principal, Rate, Time, MonthlyAmount, MonthlyInterest);
        }
        public Decimal StandingCharge { get; set; }
        public Decimal Principal { get; set; }
        public Decimal Rate { get; set; }
        public int Time { get; set; }
        public Decimal Interest { get; set; }
        public Decimal Amount { get; set; }
        public Decimal MonthlyAmount { get; set; }
        public Decimal MonthlyInterest { get; set; }
        public Decimal MonthlyStandingCharge { get; set; }

    }
}
