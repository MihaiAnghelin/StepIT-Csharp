using System;

namespace Referinte
{
    class Utils
    {
        public static void Reverse(ref string initialString)
        {
            string reverseString = "";
            for (int i = initialString.Length - 1; i >= 0; i--)
            {
                reverseString += initialString[i];
            }

            initialString = reverseString;
        }
    }
    class Test
    {
        public static void Main()
        {
            Console.WriteLine("Introduceti string-ul ce doriti sa fie inversat:");
            string str = Console.ReadLine();
            Utils.Reverse(ref str);
            Console.WriteLine("String-ul inversat este: " + str);
        }
    }
}
