using System;

namespace Vectori
{
    public class Diagonalele_matricelor
    {
        private static void Main2()
        {    
            
            int m1, n1; // The dimensions of the first matrix.
            int m2, n2; // The dimensions of the second matrix.
            
            
            // Read the dimensions of the matrices from the console.
            Console.WriteLine("Enter: ");
            Console.Write("* number of lines and colons of the first matrix: ");
            m1 = Int32.Parse(Console.ReadLine());

            n1 = m1; // Bc we need a square matrix.
            
            Console.Write("* number of lines and colons of the second matrix: ");
            m2 = Int32.Parse(Console.ReadLine());

            n2 = m2;

            int[,] matrix1 = new int[m1, n1]; // Declare and instantiate the first matrix.
            int[,] matrix2 = new int[m2, n2]; // Declare and instantiate the second matrix.

            // Read the first matrix character by character.
            for (int i = 0; i < m1; i++)
            {
                for (int j = 0; j < n1; j++)
                {
                    Console.Write("a[" + i + "][" + "[" + j + "] = ");
                    matrix1[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            
            // Write the first matrix
            for (int i = 0; i < m1; i++)
            {
                for (int j = 0; j < n1; j++)
                {
                    Console.Write(matrix1[i, j] +" ");
                }
                Console.WriteLine();
            }
            
            // Read the second matrix character by character.
            for (int i = 0; i < m1; i++)
            {
                for (int j = 0; j < n1; j++)
                {
                    Console.Write("b[" + i + "][" + "[" + j + "] = ");
                    matrix2[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            
            // Write the second matrix.
            for (int i = 0; i < m1; i++)
            {
                for (int j = 0; j < n1; j++)
                {
                    Console.Write(matrix2[i, j] +" ");
                }
                Console.WriteLine();
            }
            
            
            Console.WriteLine("Main diagonal of the first matrix is: ");
            for (int i = 0; i < m1; i++)
            {
                Console.Write(matrix1[i, i] + " ");
            }
            
            Console.WriteLine("\nThe second diagonal of the second matrix is: ");
            for (int i = 0; i < m1; i++)
            {
                Console.Write(matrix2[m1 - i - 1, i] + " ");
            }
        }
    }
}