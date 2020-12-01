using System;
using System.Diagnostics;

namespace Problem5
{
    class Program
    {
        private static Stopwatch _stopwatch = new Stopwatch();

        static void Main(string[] args)
        {
            _stopwatch.Start();
            int r = 20;

            while (r % 2 != 0 || r % 3 != 0 || r % 4 != 0 || r % 5 != 0 || r % 6 != 0 || r % 7 != 0 || r % 8 != 0 ||
                   r % 9 != 0 || r % 10 != 0 || r % 11 != 0 || r % 12 != 0 || r % 13 != 0 || r % 14 != 0 || r % 15 != 0 ||
                   r % 16 != 0 || r % 17 != 0 || r % 18 != 0 || r % 19 != 0 || r % 20 != 0)
            {
                r += 20;
            }

            Console.WriteLine("Result: " + r);
            _stopwatch.Stop();
            Console.WriteLine("Time: " + _stopwatch.Elapsed);
        }
    }
}