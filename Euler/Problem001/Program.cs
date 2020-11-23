using System;
using System.Diagnostics;

namespace Problem1
{
    class Program
    {
        private static Stopwatch _stopwatch = new Stopwatch();

        static void Main(string[] args)
        {
            _stopwatch.Start();
            var sum = 0;

            for (var i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }

            Console.WriteLine("Result: " + sum);
            _stopwatch.Stop();
            Console.WriteLine("Time: " + _stopwatch.Elapsed);
        }
    }
}