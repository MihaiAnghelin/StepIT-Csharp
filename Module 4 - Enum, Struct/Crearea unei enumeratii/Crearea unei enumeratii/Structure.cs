using System;

namespace Crearea_unei_enumeratii
{
    struct BankAccount
    {
        public long accNumber;
        public int accInterest;
        public AccountType accType;
    }
    
    public class Structure
    {
        public static void Main2()
        {
            BankAccount account;
            
            
            // Initialization
            Console.Write("Account number: ");
            account.accNumber = Convert.ToInt64(Console.ReadLine());
            
            Console.Write("Account Interest: ");
            account.accInterest = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Account Type: ");
            string type = Console.ReadLine();

            switch (type)
            {
                case "Cec":
                    account.accType = AccountType.Cec;
                    break;
                case "Depozit":
                    account.accType = AccountType.Depozit;
                    break;
                default:
                    account.accType = AccountType.Depozit;
                    break;
            }
            
            // Print
            Console.WriteLine("\nYour account :" +
                              "\n" + account.accNumber +
                              "\n" + account.accInterest +
                              "\n" + account.accType);

        }
    }
}