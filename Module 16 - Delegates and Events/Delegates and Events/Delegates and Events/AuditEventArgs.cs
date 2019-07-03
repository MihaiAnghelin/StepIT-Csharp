using System;

namespace Delegates_and_Events
{
    public class AuditEventArgs : EventArgs
    {
        private readonly BankTransaction _transData = null;
        public AuditEventArgs(BankTransaction bankTransaction) => _transData = bankTransaction;
        public BankTransaction GetTransaction()
        {
            return _transData;
        }
        
    }
}
