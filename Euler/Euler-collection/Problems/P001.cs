using System;

namespace Euler_collection.Problems
{
    /*
     * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these
     * multiples is 23.
     *
     * Find the sum of all the multiples of 3 or 5 below 1000.
     */
    
    public class P001 : ProblemBase
    {
        protected override void Run()
        {
            var result = 0;

            for (var i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    result += i;
            }

            Console.WriteLine("Result: {0}", result);
        }
    }
}