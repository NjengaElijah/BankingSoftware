using System;

namespace Moshi_Bank.Models
{
    public class AccountType
    {
        public String Name
        {
            get
            {
                String type = "";
                switch (Type){
                    case 0:
                        type = "Current Acccount";
                        break;
                    case 1:
                        type = "Fixed Deposit";
                        break;
                }return type;
            }
            set
            {
            }
        }
        public int Type
        {
            get;
            set;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
