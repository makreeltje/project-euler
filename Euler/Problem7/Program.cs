using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem7
{
    class Program
    {
        public static void Main(string[] args)
        {
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

            Console.WriteLine(num);
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