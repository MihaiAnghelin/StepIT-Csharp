using System;
using System.IO;

namespace Recap
{
    class DepositAccount : BankAccount
    {
        public bool WithdrawRequest;
        private decimal _amount;
        private double _interestAmount;
        private AccountType _accountType;

        public DepositAccount(string name, AccountType type) : base(name)
        {
            _accountType = type;
        }

        public void MakeADeposit(decimal suma)
        {
            _amount += suma;
            switch (_accountType)
            {
                case AccountType.OneYear:
                    _interestAmount += (int)suma * 0.04;
                    break;
                case AccountType.TwoYears:
                    _interestAmount += (int)suma * 0.06;
                    break;
                case AccountType.ThreeYears:
                    _interestAmount += (int)suma * 0.08;
                    break;
            }

            StreamWriter _streamWriter = new StreamWriter(logFile, true);
            _streamWriter.WriteLine("Suma depusa este: " + suma + "\nSuma totala este: " + _amount + "\nDobanda este: " +
                                    _interestAmount);
            _streamWriter.WriteLine("-----------");
            _streamWriter.Close();
        }

        public void WithdrawNow()
        {
            WithdrawRequest = true;
        }

        public override void Info(ref string accountInfo)
        {
            base.Info(ref accountInfo);
            accountInfo += "Suma este " + _amount + " -- Dobanda este " + _interestAmount;
        }
    }
}