namespace Metode
{
    public class Utils
    {
        public static int Minim(int a, int b)
        {
            return a < b ? a : b;
        }

        public static void Swap(ref int a, ref int b)
        {
            a = a ^ b;
            b = b ^ a;
            a = a ^ b;
        }

        public static int Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
            
        }
    }
}