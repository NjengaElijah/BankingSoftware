using System;

namespace Moshi_Bank.Models
{
    public class CreditDebit
   {
       public Transaction Transaction
       {
           get;
           set;
       }
       public TransactionDescription TransactionDescription
       {
           get;
           set;
       }
       public String Id
       {
           get;
           set;
       }
       public Account Account
       {
           get;
           set;
       }
       public int TransactionType
       {
           get;
           set;
       }
       public Double Credit
       {
           get;
           set;
       }
       public Double Debit
       {
           get;
           set;
       }
       public Double NewBalance
       {
           get;
           set;
       }
       public Double PrevBalance
       {
           get;
           set;
       }
       public DateTime DateStamp
       {
           get;
           set;
       }
    }
}
