using System;
using System.Diagnostics;

namespace Problem6
{
    class Program
    {
        private static Stopwatch _stopwatch = new Stopwatch();
        static void Main(string[] args)
        {
            _stopwatch.Start();
            int number = 0;
            int squareNumber = 0;
            for (int i = 1; i < 101; i++)
            {
                number += i * i;
                squareNumber += i;
            }

            var result = (squareNumber * squareNumber) - number;
            
            Console.WriteLine("Result: " + result);
            _stopwatch.Stop();
            Console.WriteLine("Time: " + _stopwatch.Elapsed);
        }
    }
}