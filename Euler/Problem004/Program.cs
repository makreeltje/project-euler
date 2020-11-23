using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Problem4
{
    class Program
    {
        private static Stopwatch _stopwatch = new Stopwatch();

        static void Main(string[] args)
        {
            _stopwatch.Start();
            var result = 0;
            for (int i = 999; i > 100; i--)
            {
                for (int j = 999; j > 100; j--)
                {
                    var temp = i * j;
                    if (temp.ToString() == new string(temp.ToString().Reverse().ToArray()))
                    {
                        if (temp > result)
                        {
                            result = temp;
                        }
                    }
                }
            }
            Console.WriteLine("Result: " + result);
            _stopwatch.Stop();
            Console.WriteLine("Time: " + _stopwatch.Elapsed);
        }
    }
}