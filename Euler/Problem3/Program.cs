using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = 600851475143;
            long b;
            

            for (b = 2; b < n; b++)
            {
                if (n % b == 0)
                {
                    n = n / b;
                }
            }
            Console.WriteLine(n);
        }
    }
}