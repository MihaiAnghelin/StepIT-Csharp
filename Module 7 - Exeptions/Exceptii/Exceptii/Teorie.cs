using System;

namespace Exceptii
{
    class Teorie
    {
        static void Main1(string[] args)
        {
            bool notNumber = false;
            do
            {
                try
                {
                    Console.Write("i = ");
                    int i = int.Parse(Console.ReadLine());
                    Console.Write("j = ");
                    int j = int.Parse(Console.ReadLine());
                    int k = i / j;
                    Console.Write("i / j = " + k);
                    Console.WriteLine();
                    notNumber = false;

                    string[] array = new string[5];
                    Console.WriteLine(array[5]);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Introduceti un intreg!");
                    notNumber = true;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Nu se poate impartii la 0!");
                    notNumber = true;
                }
                catch (IndexOutOfRangeException exp)
                {
                    Console.WriteLine(exp);
                }
                catch (Exception)
                {
                    Console.WriteLine("I have no ideea what is happening!!!");
                    notNumber = true;
                }
            } while (notNumber);
        }
    }
}
