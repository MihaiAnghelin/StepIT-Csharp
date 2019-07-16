// Cititi de la tastatura un numar natural n cu valori intre 1 si 9.
// Calculati suma s = 11 + 22 + 33 + ... + nn.

using System;

namespace Exercitiu_procedural
{
    class Program
    {
        static void Main()
        {
            int n, s;
            Console.Write("n [1,9] = ");
            n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    s += (i * 10 + i);
            //}

            s = ((n * (n + 1)) / 2) * 11;

            Console.WriteLine("s = " + s);
        }
    }
}
