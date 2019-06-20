using System;

namespace Sortarea_unui_vector
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] vector;
            int n;
            Console.Write("Number of elements: ");
            n = int.Parse(Console.ReadLine());
            vector = new int[n];
            try
            {
                
                for (int i = 0; i < n; i++)
                {
                    Console.Write("vector[{0}] = ", i);
                    vector[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < n; i++)
                {
                    Console.Write("{0} ", vector[i]);
                }
            }
            catch (IndexOutOfRangeException exp)
            {
                Console.WriteLine(exp);
            }
            catch (FormatException exp)
            {
                Console.WriteLine(exp);
            }
            Array.Sort(vector);
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", vector[i]);
            }
        }
    }
}