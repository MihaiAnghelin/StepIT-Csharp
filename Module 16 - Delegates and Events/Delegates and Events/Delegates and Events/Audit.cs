using System.IO;

namespace Delegates_and_Events
{
    public delegate void AuditEventHandler(object sender, AuditEventArgs eventData);
    internal class Audit
    {
        private string _fileName;
        private readonly StreamWriter _auditFile;
        private bool _closed;
        public Audit(string fileToUse)
        {
            _fileName = fileToUse;
            _auditFile = File.AppendText(fileToUse);
        }

        public void RecordTransaction(object sender, AuditEventArgs eventData)
        {
            BankTransaction bankTransaction = eventData.GetTransaction();
            _auditFile.WriteLine(bankTransaction.Amount + "---" + bankTransaction.Date);
        }

        public void EOFSeparator()
        {
            _auditFile.WriteLine("-----------------------");
        }

        public void Close()
        {
            if (_closed) return;
            _auditFile.Close();
            _closed = true;
        }
    }
}
