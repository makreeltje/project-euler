using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 0;
            var b = 1;
            var sum = 0;

            for (var i = 2; i < int.MaxValue; i++)
            {
                var temp = a + b;
                a = b;
                b = temp;
                if (temp > 4000000)
                    break;
                if (temp % 2 == 0)
                {
                    sum += temp;
                }
            }
            
            Console.WriteLine(sum);
        }
    }
}