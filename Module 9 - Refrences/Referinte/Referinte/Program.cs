using System;

namespace OOP
{
    public enum AccountType
    {
        Cec,
        Depozit
    }
    class BankAccount
    {
        private long accNumber;
        private int accInterest;
        private AccountType accType;
        private decimal balance;

        private static long succNrCont = 123;

        private static long NextNumber()
        {
            succNrCont++;
            return succNrCont;
        }

        public void Populate(int accInterest, AccountType accType)
        {
            this.accNumber = NextNumber();
            this.accInterest = accInterest;
            this.accType = accType;
        }

        public long ReturnAccNumber()
        {
            return accNumber;
        }
        public int ReturnAccInterest()
        {
            return accInterest;
        }
        public AccountType ReturnType()
        {
            return accType;
        }
        public decimal ReturnBalance()
        {
            return balance;
        }

        public void TransferForm(BankAccount sourceAccount, int amount)
        {
            bool canWithdraw = sourceAccount.Withdraw(amount);

            if (!canWithdraw)
            {
                Console.WriteLine("Nu exista suficienti bani in contul sursa.");
                return;
            }

            this.Deposit(amount);
        }

        public static void TestDeposit(BankAccount bankAccount)
        {
            Console.WriteLine("Introoduceti suma de bani pe care doriti sa o depuneti: ");
            decimal value /*= decimal.Parse(Console.ReadLine())*/;
            decimal.TryParse(Console.ReadLine(), out value);

            bankAccount.Deposit(value);
        }

        public decimal Deposit(decimal amount)
        {
            balance += amount;

            return balance;
        }

        public static void TestWithdraw(BankAccount bankAccount)
        {
            Console.WriteLine("Introoduceti suma de bani pe care doriti sa o extrageti: ");

            decimal amount;
            decimal.TryParse(Console.ReadLine(), out amount);

            bool canWithdraw = bankAccount.Withdraw(amount);

            if (!canWithdraw)
            {
                Console.WriteLine("Nu aveti suficienti bani in cont.");
            }
        }

        public bool Withdraw(decimal amount)
        {
            if (balance - amount < 0)
            {
                return false;
            }

            balance -= amount;

            return true;
        }
    }
    class Program
    {
        static void Main1()
        {
            BankAccount ba1 = new BankAccount();
            ba1.Populate(1, AccountType.Cec);
            ba1.Deposit(100);

            BankAccount ba2 = new BankAccount();
            ba2.Populate(2, AccountType.Cec);
            ba2.Deposit(100);


            Console.WriteLine("Tipul contului 1 este: " + ba1.ReturnType());
            Console.WriteLine("Numarul contului 1 este: " + ba1.ReturnAccNumber());
            Console.WriteLine("Suma din contul 1 este: " + ba1.ReturnBalance());
            Console.WriteLine();
            Console.WriteLine("Tipul contului 2 este: " + ba2.ReturnType());
            Console.WriteLine("Numarul contului 2 este: " + ba2.ReturnAccNumber());
            Console.WriteLine("Suma din contul 2 este: " + ba2.ReturnBalance());
            Console.WriteLine();

            ba1.TransferForm(ba2, 50);
            Console.WriteLine("S-a efectuat o tranzactie de 50 de lei din contul 2 in contul 1.");
            Console.WriteLine("Suma din contul 1 este: " + ba1.ReturnBalance());
            Console.WriteLine("Suma din contul 2 este: " + ba2.ReturnBalance());
        }


    }
}