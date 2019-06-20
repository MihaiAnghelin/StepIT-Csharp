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
        static void Main()
        {
            BankAccount ba1 = new BankAccount();
            ba1.Populate(1, AccountType.Cec);

            BankAccount ba2 = new BankAccount();
            ba2.Populate(2, AccountType.Cec);

            Console.WriteLine("Numarul contului meu este: " + ba1.ReturnAccNumber());
            Console.WriteLine("Dobanda contului meu este: " + ba1.ReturnAccInterest());
            Console.WriteLine("Tipul contului meu este: " + ba1.ReturnType());
            Console.WriteLine("Suma din cont este: " + ba1.ReturnBalance());

            BankAccount.TestDeposit(ba1);
            Console.WriteLine("Suma din cont este: " + ba1.ReturnBalance());

            BankAccount.TestWithdraw(ba1);
            Console.WriteLine("Suma din cont este: " + ba1.ReturnBalance());

        }


    }
}
