using System;

namespace Crearea_unei_enumeratii
{
    public class Number
    {
        public static void Main()
        {
            Console.Write("Choose a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("Your number is prime.");
            }
            else
            {
                Console.WriteLine("Your number is not prime.");
            }
        }
    }
}