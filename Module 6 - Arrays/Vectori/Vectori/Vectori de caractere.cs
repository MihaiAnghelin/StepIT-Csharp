using System;

namespace Vectori
{
    public class Vectori_de_caractere
    {
        private static void Summarize(char[] elements)
        {
            string vocals = "aeiouAEIOU";
            string consonants = "qwrtypsdfghjklzxcvbnmQWRTYPSDFGHJKLZXCVBNM";
            int vocalsNumber = 0;
            int consonantNumber = 0;
            int specialChars = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                if (vocals.IndexOf(elements[i]) != -1)
                {
                    vocalsNumber++;
                }
                else if (consonants.IndexOf(elements[i]) != -1)
                {
                    consonantNumber++;
                }
                else
                {
                    specialChars++;
                }
            }

            Console.WriteLine("In the first word are: \n" + vocalsNumber + " vocals,");
            Console.WriteLine(consonantNumber + " consonants,");
            Console.WriteLine(specialChars + " special characters.");
        }
        
        static void Main1(string[] args)
        {
            char[] elements = args[0].ToCharArray();
            
            foreach (var t in args)
            {
                Console.WriteLine(t);
            }

            Summarize(elements);
        }
    }
}