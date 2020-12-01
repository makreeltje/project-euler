using System;

namespace Euler_collection.Problems
{
    /*
     * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
     * 
     * What is the 10 001st prime number?
     */
    
    public class P007 : ProblemBase
    {
        protected override void Run()
        {
            var count = 0;
            const int limit = 10001;
            var result = 2;
            
            while (true)
            {
                if (IsPrime(result))
                {
                    count++;
                }

                if (count == limit)
                {
                    break;
                }

                result++;
            }
            
            Console.WriteLine("Result: {0}", result);
        }

        private static bool IsPrime(int num)
        {
            for (var i = 2; i < num; i++)
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