using System;

namespace Euler_collection.Problems
{
    /*
     * The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
     *
     * Find the sum of all the primes below two million.
     */
    
    public class P010 : ProblemBase
    {
        protected override void Run()
        {
            var result = 2L;
            
            for (var i = 3; i < 2000000; i+=2)
            {
                if (IsPrime(i))
                {
                    result += i;
                }
            }
            
            Console.WriteLine("Result: {0}", result);
        }

        private static bool IsPrime(long num)
        {
            var sqrt = (int) Math.Sqrt(num);
            for (var i = 2; i <= sqrt; i++)
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