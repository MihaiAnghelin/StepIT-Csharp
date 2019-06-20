using System;
using System.Collections;

namespace Constructors_and_destructors
{
    public enum AccountType
    {
        Cec,
        Depozit
    }

    class BankTransaction
    {
        private readonly decimal amount;
        private readonly DateTime date;
        public decimal GetAmount()
        {
            return amount;
        }
        public DateTime GetDate()
        {
            return date;
        }
        public BankTransaction(decimal amount)
        {
            this.amount = amount;
            date = DateTime.Now;
        }
    }

    class BankAccount
    {
        #region Variables

        private long accNumber;
        private int accInterest;
        private AccountType accType;
        private decimal balance;
        private static long succNrCont = 123;

        private Queue transactionQueue = new Queue();

        #endregion

        #region Constructors

        public BankAccount()
        {
            accNumber = NextNumber();
            balance = 0;
            accType = AccountType.Cec;
        }
        public BankAccount(AccountType tCont)
        {
            accNumber = NextNumber();
            balance = 0;
            accType = tCont;
        }
        public BankAccount(decimal sCont)
        {
            accNumber = NextNumber();
            balance = sCont;
            accType = AccountType.Cec;
        }
        public BankAccount(AccountType tCont, decimal sCont)
        {
            accNumber = NextNumber();
            balance = sCont;
            accType = tCont;
        }

        #endregion

        #region Getters

        public long GetAccNumber()
        {
            return accNumber;
        }
        public int GetAccInterest()
        {
            return accInterest;
        }
        public AccountType GetAccType()
        {
            return accType;
        }
        public decimal GetBalance()
        {
            return balance;
        }
        public Queue GetTransaction()
        {
            return transactionQueue;
        }

        #endregion

        #region Methods

        private static long NextNumber()
        {
            succNrCont++;
            return succNrCont;
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
            Console.Write("Introduceti suma de bani pe care doriti sa o depuneti: ");
            decimal value /*= decimal.Parse(Console.ReadLine())*/;
            decimal.TryParse(Console.ReadLine(), out value);            
            bankAccount.Deposit(value);
            Console.WriteLine();
        }

        public decimal Deposit(decimal amount)
        {
            balance += amount;

            BankTransaction bankTransaction = new BankTransaction(amount);
            transactionQueue.Enqueue(bankTransaction);
            return balance;
        }

        public static void TestWithdraw(BankAccount bankAccount)
        {
            Console.Write("Introoduceti suma de bani pe care doriti sa o extrageti: ");

            decimal amount;
            decimal.TryParse(Console.ReadLine(), out amount);

            bool canWithdraw = bankAccount.Withdraw(amount);

            if (!canWithdraw)
            {
                Console.WriteLine("Nu aveti suficienti bani in cont.");
            }
            Console.WriteLine();
        }

        public bool Withdraw(decimal amount)
        {
            if (balance - amount < 0)
            {
                return false;
            }

            balance -= amount;
            BankTransaction bankTransaction = new BankTransaction(-amount);
            transactionQueue.Enqueue(bankTransaction);

            return true;
        }

        public static void Write(BankAccount bankAccount)
        {
            Console.WriteLine("Account number : " + bankAccount.GetAccNumber());
            Console.WriteLine("Account interest : " + bankAccount.GetAccInterest());
            Console.WriteLine("Account type : " + bankAccount.GetAccType());
            Console.WriteLine("Account balanace: " + bankAccount.GetBalance());
            foreach (BankTransaction tran in bankAccount.GetTransaction())
            {
                Console.WriteLine("Data / Ora: {0}\tSuma: {1}", tran.GetDate(), tran.GetAmount());
            }
            Console.WriteLine();
        }

        #endregion
    }
    class Program
    {
        static void Main()
        {
            BankAccount account1 = new BankAccount();
            BankAccount account2 = new BankAccount(AccountType.Depozit);
            BankAccount account3 = new BankAccount(100);
            BankAccount account4 = new BankAccount(AccountType.Depozit, 500);


            BankAccount.Write(account1);
            //BankAccount.Write(account2);
            //BankAccount.Write(account3);
            //BankAccount.Write(account4);


            BankAccount.TestDeposit(account1);
            BankAccount.Write(account1);

            BankAccount.TestWithdraw(account1);
            BankAccount.Write(account1);

            BankAccount.TestDeposit(account1);
            BankAccount.Write(account1);
        }
    }
}