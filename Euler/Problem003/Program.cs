using System;
using System.Diagnostics;

namespace Problem3
{
    class Program
    {
        private static Stopwatch _stopwatch = new Stopwatch();

        static void Main(string[] args)
        {
            _stopwatch.Start();
            long n = 600851475143;
            long b;
            

            for (b = 2; b < n; b++)
            {
                if (n % b == 0)
                {
                    n = n / b;
                }
            }
            Console.WriteLine("Result: " + n);
            _stopwatch.Stop();
            Console.WriteLine("Time: " + _stopwatch.Elapsed);
        }
    }
}