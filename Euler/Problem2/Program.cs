using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int sum = 0;

            for (int i = 2; i < int.MaxValue; i++)
            {
                int temp = a + b;
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