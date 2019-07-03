using System;

namespace Delegates_and_Events
{
    public class BankTransaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }

        public BankTransaction(decimal amount)
        {
            Amount = amount;
            Date = DateTime.Now;
        }
    }
}