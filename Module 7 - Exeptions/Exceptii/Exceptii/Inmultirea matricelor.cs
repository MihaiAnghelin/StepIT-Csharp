using System;

namespace Exceptii
{
    class Inmultirea_matricelor
    {
        private static void Main()
        {
            try
            {
                #region Citirea celor doua matrice
                int m1, n1; // The dimensions of the matrix.

                // Read the dimensions of the matrix from the console.
                Console.Write("* number of lines of the matrix: ");
                m1 = Int32.Parse(Console.ReadLine());

                Console.Write("* number of colons of the matrix: ");
                n1 = Int32.Parse(Console.ReadLine());

                int[,] matrix1 = new int[m1, n1]; // Declare and instantiate the matrix.

                // Read the first matrix character by character.
                for (int i = 0; i < m1; i++)
                {
                    for (int j = 0; j < n1; j++)
                    {
                        Console.Write("a[" + i + "][" + j + "] = ");
                        matrix1[i, j] = Int32.Parse(Console.ReadLine());
                    }
                }

                int m2, n2; // The dimensions of the matrix.

                // Read the dimensions of the matrix from the console.
                Console.Write("* number of lines of the matrix: ");
                m2 = Int32.Parse(Console.ReadLine());

                Console.Write("* number of colons of the matrix: ");
                n2 = Int32.Parse(Console.ReadLine());

                if (n1 != m2)
                {
                    throw new ArgumentOutOfRangeException();
                }

                int[,] matrix2 = new int[m2, n2]; // Declare and instantiate the matrix.

                // Read the first matrix character by character.
                for (int i = 0; i < m2; i++)
                {
                    for (int j = 0; j < n2; j++)
                    {
                        Console.Write("a[" + i + "][" + j + "] = ");
                        matrix2[i, j] = Int32.Parse(Console.ReadLine());
                    }
                }
                #endregion

                int[,] matrix3 = new int[m1, n2];

                #region Inmultirea matricelor
                for (int i = 0; i < m1; i++)
                {
                    for (int j = 0; j < n2; j++)
                    {
                        for (int k = 0; k < n1; k++)
                        {
                            matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
                        }
                    }
                }
                Console.WriteLine("The product of the two matrices is :");
                for (int i = 0; i < m1; i++)
                {
                    for (int j = 0; j < n2; j++)
                    {
                        Console.Write(matrix3[i, j] + "\t");
                    }
                    Console.WriteLine();
                }


                #endregion
            }
            catch (FormatException)
            {
                Console.WriteLine("\nRead an integer!\n");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("\nThe number of colons of the first matrix is not equal to \nthe number of lines of the second one!\n");
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
            }
        }
    }
}
