using System;

namespace Crearea_unei_enumeratii
{
    public enum AccountType
    {
        Cec,
        Depozit
    }
    
    public static class Enumeration
    {
        public static void Main1()
        {
            AccountType accountType1, accountType2;
            accountType1 = AccountType.Cec;
            accountType2 = AccountType.Depozit;
            
            Console.WriteLine(accountType1);
            Console.WriteLine(accountType2);
        }
    }
}