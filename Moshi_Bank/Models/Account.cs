using System;

namespace Moshi_Bank.Models
{
    public class Account
    {
        public String Number
        {
            get;
            set;
        }
        public String Names
        {
            get;
            set;
        }
        public Double Balance
        {
            get;
            set;
        }
        public AccountType Type
        {
            get;
            set;
        }
        public int UserId
        {
            get;
            set;
        }
        public String DateCreated
        {
            get;
            set;
        }
        public String PIN
        {
            get;
            set;
        }
        public int Status
        {
            get;
            set;
        }
        public Boolean isActive
        {
            get
            {
                bool active = false;
                if (Status == 1)
                {
                    active = true;
                }
                else if (Status == 2)
                {
                    active = false;
                }
                return active;
            }
        }
        public String State
        {
            get
            {
                String active = "Deactivated";
                if (isActive)
                {
                    active = "Activated";
                }
                else if (!isActive)
                {
                    active = "Deactivated";
                }
                return active;
            }
        }
    }
}
