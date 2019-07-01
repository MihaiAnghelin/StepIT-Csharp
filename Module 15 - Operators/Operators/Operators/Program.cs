using System;
using System.Collections;
using System.IO;

namespace Operators
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

        public BankAccount(AccountType accountType)
        {
            AccNumber = NextNumber();
            Balance = 0;
            AccType = accountType;
        }

        public BankAccount(decimal balance)
        {
            AccNumber = NextNumber();
            Balance = balance;
            AccType = AccountType.Cec;
        }

        public BankAccount(AccountType accountType, decimal balance)
        {
            AccNumber = NextNumber();
            Balance = balance;
            AccType = accountType;
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

        public override bool Equals(Object obj)
        {
            BankAccount ba2 = (BankAccount) obj;
            return AccNumber == ba2.AccNumber &&
                   AccType == ba2.AccType &&
                   Balance == ba2.Balance;
        }

        public override int GetHashCode()
        {
            return (int) AccNumber;
        }

        public static bool operator ==(BankAccount ba1, BankAccount ba2)
        {
            return ba1?.AccNumber == ba2?.AccNumber &&
                   ba1?.AccType == ba2?.AccType &&
                   ba1?.Balance == ba2?.Balance;
        }

        public static bool operator !=(BankAccount ba1, BankAccount ba2)
        {
            return !(ba1?.AccNumber == ba2?.AccNumber &&
                     ba1?.AccType == ba2?.AccType &&
                     ba1?.Balance == ba2?.Balance);
        }

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

                return (BankTransaction) enumerator.Current;
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

            fout.WriteLine("Numar de cont " + AccNumber + ", sold " + Balance + ", tipul contului: " + AccType +
                           ", coada de tranzactii: ");
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

    

    internal class Rational
    {
        private readonly int _numarator;
        private readonly int _numitor;

        public Rational(int numarator)
        {
            this._numarator = numarator;
            _numitor = 1;
        }

        public Rational(int numarator, int numitor)
        {
            this._numarator = numarator;
            if(numitor==0)
                throw new ArgumentException();
            this._numitor = numitor;
        }

        public static bool operator ==(Rational r1, Rational r2)
        {
            return r1.GetDecimalValue() == r2.GetDecimalValue();
        }

        public static bool operator !=(Rational r1, Rational r2)
        {
            return !(r1.GetDecimalValue() == r2.GetDecimalValue());
        }

        public override bool Equals(object obj)
        {
            Rational r2 = (Rational)obj;
            return GetDecimalValue() == r2.GetDecimalValue(); ;
        }

        public override string ToString()
        {
            return _numarator + " / " + _numitor;
        }

        public decimal GetDecimalValue()
        {
            return ((decimal)_numarator / _numitor);
        }

        public static bool operator <(Rational r1, Rational r2)
        {
            return r1.GetDecimalValue() < r2.GetDecimalValue();
        }

        public static bool operator >(Rational r1, Rational r2)
        {
            return r1.GetDecimalValue() > r2.GetDecimalValue();
        }

        public static bool operator <=(Rational r1, Rational r2)
        {
            return r1.GetDecimalValue() <= r2.GetDecimalValue();
        }

        public static bool operator >=(Rational r1, Rational r2)
        {
            return r1.GetDecimalValue() >= r2.GetDecimalValue();
        }
    }

    internal class Program
    {
        private static void Main()
        {
            /*
            BankAccount ba1 = new BankAccount(AccountType.Cec, 500);
            BankAccount ba2 = new BankAccount(AccountType.Cec, 200);
            Console.WriteLine(ba1 == ba2);
            Console.WriteLine(ba1 != ba2);
            Console.WriteLine(ba1.Equals(ba2));
            Console.WriteLine(ba1.ToString());
            Console.WriteLine(ba2.ToString());
            Console.Read();
            */
            Rational r1 = new Rational(13, 17);
            Rational r2 = new Rational(26,34);
            Console.WriteLine(r1 + " " + r1.GetDecimalValue());
            Console.WriteLine(r2 + " " + r2.GetDecimalValue());
            Console.WriteLine(r1==r2);
            
            Console.Read();
        }
    }
}