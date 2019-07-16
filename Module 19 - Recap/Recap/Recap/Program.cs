using System;
using System.Diagnostics;

namespace Recap
{
    public delegate void Deposit(object sender, DepositArgs args);
    internal static class Program
    {
        private static void Main()
        {
            Bank bank = new Bank();
            bank.Init();

            bool ok = true;
            while (ok)
            {
                bank.List();
                Console.WriteLine("k. Inchideti programul.");
                Console.WriteLine();
                Console.WriteLine("Selectati contul in care doriti sa faceti actiunea: ");
                var accountNumber = Console.ReadLine();
                if (accountNumber == "k")
                {
                    ok = false;
                    break;
                }
                Console.Clear();
                Console.WriteLine("Selectati actiunea dorita: ");
                Console.WriteLine("1.Depositati bani.");
                Console.WriteLine("2.Inapoi.");
                Console.WriteLine("k.Inchideti programul.");
                var command = Console.ReadLine();
                Console.Clear();
                switch (command)
                {
                    case "1":
                        Console.WriteLine("Indroduceti suma dorita: ");
                        int amount = int.Parse(Console.ReadLine());
                        bank.DepositTrigger(bank[int.Parse(accountNumber)].GetAccountID(), amount);
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        break;
                    case "k":
                        Console.Clear();
                        ok = false;
                        break;
                }
            }
        }
    }
}
