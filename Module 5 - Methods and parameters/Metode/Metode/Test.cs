using System;

namespace Metode
{
    public class Test
    {
        private static void Main()
        {
            int a, b;
            Console.Write("a = ");
            a = Int32.Parse(Console.ReadLine());
            
            Console.Write("b = ");
            b = Int32.Parse(Console.ReadLine());

            int min = Utils.Minim(a, b);

            Console.WriteLine("The minimum between a and b is " + min);


            int x, y;
            Console.Write("x = ");
            x = Int32.Parse(Console.ReadLine());
            
            Console.Write("y = ");
            y = Int32.Parse(Console.ReadLine());

            Console.WriteLine("x = {0}, y = {1}, before swap", x, y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("x = {0}, y = {1}, after swap", x, y);

            int f;
            f = Utils.Factorial(x);
            Console.WriteLine("x! = " + f);

        }
    }
}