using System;
using System.Collections;
using System.IO;

namespace Delegates_and_Events
{
    internal sealed class BankAccount : IDisposable
    {
        public event AuditEventHandler AuditingTransaction;

        #region Variables

        private static long _sucNrCont = 123;

        private bool _disposed;

        private Audit accountAudit;

        #endregion

        #region Getters

        public long AccNumber { get; }
        public int AccInterest { get; }
        public AccountType AccType { get; }
        public decimal Balance { get; private set; }
        public Queue Transaction { get; } = new Queue();
        public string Owner { get; set; }

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

        #region Methods

        public void AddOnAuditingTransaction(AuditEventHandler handler)
        {
            AuditingTransaction += handler;
        }

        public void RemoveOnAuditingTransaction(AuditEventHandler handler)
        {
            AuditingTransaction -= handler;
        }

        public void OnAuditingTransaction(BankTransaction bankTransaction)
        {
            if (AuditingTransaction != null)
            {
                var auditEventArgs = new AuditEventArgs(bankTransaction);
                AuditingTransaction(this, auditEventArgs);
            }
        }

        public void AuditTrail(string fileName)
        {
            if (accountAudit == null)
            {
                accountAudit = new Audit(fileName);
            }
            AuditEventHandler doAuditing = new AuditEventHandler(accountAudit.RecordTransaction);
            AddOnAuditingTransaction(doAuditing);
        }

        public override bool Equals(Object obj)
        {
            BankAccount ba2 = (BankAccount)obj;
            return AccNumber == ba2.AccNumber &&
                   AccType == ba2.AccType &&
                   Balance == ba2.Balance;
        }

        public override int GetHashCode()
        {
            return (int)AccNumber;
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
            
            accountAudit.EOFSeparator();
            accountAudit.Close();
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
            OnAuditingTransaction(bankTransaction);
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
            OnAuditingTransaction(bankTransaction);
            return true;
        }

        public static void Write(BankAccount bankAccount)
        {
            Console.WriteLine("Account number : " + bankAccount.AccNumber);
            Console.WriteLine("Account interest : " + bankAccount.AccInterest);
            Console.WriteLine("Account type : " + bankAccount.AccType);
            Console.WriteLine("Account balanace: " + bankAccount.Balance);
            //foreach (BankTransaction tran in bankAccount.Transaction)
            for (var i = 0; i < bankAccount.Transaction.Count; i++)
            {
                Console.WriteLine("Data / Ora: {0}\tSuma: {1}", bankAccount[i].Date, bankAccount[i].Amount);
            }

            Console.WriteLine();
        }

        #endregion
    }
}