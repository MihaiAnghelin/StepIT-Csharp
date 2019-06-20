using System;

namespace Operators_and_Variables
{
    class Program
    {
        private static void Problem1()
        {
            int a, b, c;
            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("c = ");
            c = Convert.ToInt32(Console.ReadLine());

            float e = (a * b) / c + (b * c) / a + (c * a) / b;

            Console.WriteLine(e);
        }

        private static void Problem2()
        {
            string s1, s2;
            Console.Write("s1 = ");
            s1 = Console.ReadLine();
            
            Console.Write("s2 = ");
            s2 = Console.ReadLine();

            s1 = s1?.Trim('#', '%', '!', '@', '$', '^');

            s2 = s2?.Trim('#', '%', '!', '@', '$', '^');

            Console.WriteLine(s1 + ' ' + s2);
        }
        
        public static void Main(string[] args)
        {
            Problem1();
            Console.WriteLine();
            Problem2();
        }
    }
}