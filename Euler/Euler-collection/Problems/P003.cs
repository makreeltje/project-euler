using System;

namespace Euler_collection.Problems
{
    
    /*
     * The prime factors of 13195 are 5, 7, 13 and 29.
     *
     * What is the largest prime factor of the number 600851475143 ?
     */

    public class P003 : ProblemBase
    {
        
        protected override void Run()
        {
            var result = 600851475143;
            var n = 0L;
            
            for (n = 2; n < result; n++)
            {
                if (result % n == 0)
                {
                    result /= n;
                }
            }
            
            Console.WriteLine("Result: {0}", result);
        }
    }
}