using System;

namespace Vectori.Properties
{
    public class Roata_matrice
    {
        
        private static void Main()
        {
            int m, n; // The dimensions of the matrix.
            
            // Read the dimensions of the matrix from the console.
            Console.WriteLine();
            Console.Write("* number of lines of the matrix: ");
            m = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine();
            Console.Write("* number of colons of the matrix: ");
            n = Int32.Parse(Console.ReadLine());
            
            int[,] matrix = new int[m, n]; // Declare and instantiate the matrix.
            
            // Read the first matrix character by character.
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("a[" + i + "][" + "[" + j + "] = ");
                    matrix[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < (n / 2 + m % 2); i++) 
            {
                for (int j = i; j < n - i; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                for (int j = i + 1; j < m - i; j++)
                {
                    Console.Write(matrix[j, n - i - 1] + " ");
                }

                for (int j = m - i - 2; j >= i; j--) 
                {
                    Console.Write(matrix[m - i - 1, j] + " ");
                }

                for (int j = m - i - 2; j >= i + 1; j--) 
                {
                    Console.Write(matrix[j, i] + " ");
                }
            }
        }
    }
}