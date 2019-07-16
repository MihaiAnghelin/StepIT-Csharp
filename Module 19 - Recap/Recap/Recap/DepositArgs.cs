using System;

namespace Recap
{
    public class DepositArgs : EventArgs
    {
        public int AccountID { get; }
        public int Amount { get; }

        public DepositArgs(int accountId, int amount)
        {
            AccountID = accountId;
            this.Amount = amount;
        }
    }
}