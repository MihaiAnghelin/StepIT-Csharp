using System;
using System.Collections;

namespace Recap
{
    class Bank
    {
        private event Deposit depositMoney;
        private ArrayList _clients;

        public void Init()
        {
            _clients = new ArrayList();

            _clients.Add(new DepositAccount("0.Laur", AccountType.OneYear));
            _clients.Add(new DepositAccount("1.Iacob", AccountType.TwoYears));
            _clients.Add(new DepositAccount("2.Mihai", AccountType.ThreeYears));

        }

        public BankAccount this[int index]
        {
            get
            {
                int currentIndex = 0;
                foreach (var account in _clients)
                {
                    if (currentIndex == index) return (BankAccount) account;
                    currentIndex++;
                }

                return null;
            }
        }

        public void CheckAccount(object sender, DepositArgs args)
        {
            for (int i = 0; i < _clients.Count; i++)
            {
                DepositAccount da = (DepositAccount) _clients[i];
                if (da.GetAccountID() == args.AccountID && da.WithdrawRequest)
                {
                    _clients.RemoveAt(i);
                    i--;
                }
            }
        }

        public void DepositMoney(object sender, DepositArgs args)
        {
            for (int i = 0; i < _clients.Count; i++)
            {
                DepositAccount da = (DepositAccount) _clients[i];
                if (da.GetAccountID() == args.AccountID)
                {
                    da.MakeADeposit(args.Amount);
                }
            }
        }

        public void DepositTrigger(int accountId, int amount)
        {
            var depositArgs = new DepositArgs(accountId, amount);
            depositMoney += CheckAccount;
            depositMoney += DepositMoney;
            depositMoney?.Invoke(this, depositArgs);
            depositMoney = null;
        }

        public void List()
        {
            foreach (DepositAccount account in _clients)
            {
                string accountInfo = "";
                account.Info(ref accountInfo);
                Console.WriteLine(accountInfo);
            }
            Console.WriteLine();
        }
    }
}