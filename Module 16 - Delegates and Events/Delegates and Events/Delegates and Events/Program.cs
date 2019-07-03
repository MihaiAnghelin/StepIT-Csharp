using System;

namespace Delegates_and_Events
{
    internal static class Program
    {
        private static void Main()
        {
            using (BankAccount accout = new BankAccount())
            {
                accout.AuditTrail("C:\\test.txt");
                accout.Owner = "Mihai";
                accout.Deposit(100);
                accout.Withdraw(50);
                accout.Withdraw(60);
                accout.Deposit(200);
                accout.Withdraw(60);
                accout.Withdraw(100);
            }

        }
    }
}