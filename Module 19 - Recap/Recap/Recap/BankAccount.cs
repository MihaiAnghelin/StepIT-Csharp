namespace Recap
{
    class BankAccount
    {
        protected string name;
        protected static int NrGenerator = 1234;
        protected int accountID;
        protected string logFile;
        

        public BankAccount(string name)
        {
            this.name = name;
            accountID = NrGenerator++;
            logFile = accountID + ".txt";
        }

        public string GetName() { return name; }
        public int GetAccountID() { return accountID; }

        public virtual void Info(ref string accountInfo)
        {
            accountInfo = name + "--" + accountID + "  ";
        }
    }
}