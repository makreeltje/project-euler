using System;
using System.Diagnostics;

namespace Problem010
{
    class Program
    {
        private static Stopwatch _stopwatch = new Stopwatch();
        
        static void Main(string[] args)
        {
            _stopwatch.Start();
            long result = 2;
            for (int i = 3; i < 2000000; i+=2)
            {
                if (isPrime(i))
                {
                    result += i;
                }
            }
            Console.WriteLine("Result: " + result);
            _stopwatch.Stop();
            Console.WriteLine("Time: " + _stopwatch.Elapsed);
        }
        
        static bool isPrime(long num)
        {
            var sqrt = (int) Math.Sqrt(num);
            for (long i = 2; i <= sqrt; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}