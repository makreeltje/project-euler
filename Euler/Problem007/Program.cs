using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Problem7
{
    
    class Program
    {
        private static Stopwatch _stopwatch = new Stopwatch();
        public static void Main(string[] args)
        {
            _stopwatch.Start();
            int count = 0;
            int num = 2;
            while (true)
            {
                if (isPrime(num))
                {
                    count++;
                }

                if (count == 10001)
                {
                    break;
                }

                num++;
            }

            Console.WriteLine("Result: " + num);
            _stopwatch.Stop();
            Console.WriteLine("Time: " + _stopwatch.Elapsed);
        }

        static bool isPrime(int num)
        {
            for (int i = 2; i < num; i++)
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