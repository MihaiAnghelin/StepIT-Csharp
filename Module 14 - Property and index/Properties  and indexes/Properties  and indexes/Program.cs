using System;
using System.Collections;
using System.IO;
using System.Threading;

namespace Properties__and_indexes
{
    public enum AccountType
    {
        Cec,
        Deposit
    }

    internal class BankTransaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public BankTransaction(decimal amount)
        {
            Amount = amount;
            Date = DateTime.Now;
        }
    }

    internal sealed class BankAccount : IDisposable
    {

        #region Variables

        private static long _sucNrCont = 123;

        private bool _disposed;

        #endregion

        #region Constructors

        public BankAccount()
        {
            AccNumber = NextNumber();
            Balance = 0;
            AccType = AccountType.Cec;
        }
        public BankAccount(AccountType tCont)
        {
            AccNumber = NextNumber();
            Balance = 0;
            AccType = tCont;
        }
        public BankAccount(decimal sCont)
        {
            AccNumber = NextNumber();
            Balance = sCont;
            AccType = AccountType.Cec;
        }
        public BankAccount(AccountType tCont, decimal sCont)
        {
            AccNumber = NextNumber();
            Balance = sCont;
            AccType = tCont;
        }

        #endregion

        #region Destructor
        ~BankAccount()
        {
            Dispose();
        }
        #endregion

        #region Getters

        public long AccNumber { get; }
        public int AccInterest { get; }
        public AccountType AccType { get; }
        public decimal Balance { get; private set; }
        public Queue Transaction { get; } = new Queue();
        public string Owner { get; set; }

        #endregion

        #region Methods

        public BankTransaction this[int ind]
        {
            get
            {
                if (ind < 0 || ind >= Transaction.Count)
                {
                    return null;
                }

                IEnumerator enumerator = Transaction.GetEnumerator();
                int count = 0;
                while (count <= ind)
                {
                    enumerator.MoveNext();
                    count++;
                }

                return (BankTransaction)enumerator.Current;
            }
        }

        public override string ToString()
        {
            return Owner + " " + AccNumber + " " + AccInterest + " " + AccType + " " + Balance;
        }
        public void Dispose()
        {
            if (_disposed) return;

            StreamWriter fout = File.AppendText("Tranzactii.txt");

            fout.WriteLine("Numar de cont " + AccNumber + ", sold " + Balance + ", tipul contului: " + AccType + ", coada de tranzactii: ");
            foreach (BankTransaction tran in Transaction)
            {
                fout.WriteLine("Data / Ora: {0}\tSuma: {1}", tran.Date, tran.Amount);
            }
            fout.Close();
            _disposed = true;
            GC.SuppressFinalize(this);
        }

        private static long NextNumber()
        {
            _sucNrCont++;
            return _sucNrCont;
        }

        public void TransferForm(BankAccount sourceAccount, int amount)
        {
            bool canWithdraw = sourceAccount.Withdraw(amount);

            if (!canWithdraw)
            {
                Console.WriteLine("Nu exista suficienti bani in contul sursa.");
                return;
            }

            Deposit(amount);
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
            Balance += amount;

            BankTransaction bankTransaction = new BankTransaction(amount);
            Transaction.Enqueue(bankTransaction);
            return Balance;
        }

        public static void TestWithdraw(BankAccount bankAccount)
        {
            Console.Write("Introduceti suma de bani pe care doriti sa o extrageti: ");

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
            if (Balance - amount < 0)
            {
                return false;
            }

            Balance -= amount;
            BankTransaction bankTransaction = new BankTransaction(-amount);
            Transaction.Enqueue(bankTransaction);

            return true;
        }

        public static void Write(BankAccount bankAccount)
        {
            Console.WriteLine("Account number : " + bankAccount.AccNumber);
            Console.WriteLine("Account interest : " + bankAccount.AccInterest);
            Console.WriteLine("Account type : " + bankAccount.AccType);
            Console.WriteLine("Account balanace: " + bankAccount.Balance);
            //foreach (BankTransaction tran in bankAccount.Transaction)
            for (int i = 0; i < bankAccount.Transaction.Count; i++) 
            {
                Console.WriteLine("Data / Ora: {0}\tSuma: {1}", bankAccount[i].Date, bankAccount[i].Amount);
            }
            Console.WriteLine();
        }

        #endregion
    }

    internal class Program
    {
        private static void Main()
        {
            using (BankAccount account = new BankAccount())
            {
                account.Deposit(100);
                account.Withdraw(50);
                account.Deposit(75);
                account.Withdraw(50);
                account.Withdraw(30);
                account.Deposit(40);
                account.Deposit(200);
                account.Withdraw(250);
                account.Deposit(25);
                BankAccount.Write(account);
                account.Owner = "Alex";
                Console.WriteLine(account.ToString());
            }

            
        }
    }
}