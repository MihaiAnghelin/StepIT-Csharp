using System;

namespace HelloWorld
{
    class Hello
    {
        public static void Main()
        {
            Console.WriteLine("Buna ziua!");
            Console.Write("Numele meu este ");
            var nume = Console.ReadLine();
            Console.WriteLine("Buna " + nume + "!\n");

            Console.Write("Varsta mea este ");
            var varsta = Console.ReadLine();
            Console.WriteLine(nume + " are " + varsta + " ani.");
            Console.Read();
        }
    }
}

