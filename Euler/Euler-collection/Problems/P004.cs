using System;
using System.Linq;

namespace Euler_collection.Problems
{
    /*
     * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit
     * numbers is 9009 = 91 × 99.
     *
     * Find the largest palindrome made from the product of two 3-digit numbers.
     */

    public class P004 : ProblemBase
    {
        protected override void Run()
        {
            var result = 0;

            for (var i = 999; i > 100; i--)
            {
                for (var j = 999; j > 100; j--)
                {
                    var temp = i * j;
                    if (temp.ToString() != new string(temp.ToString().Reverse().ToArray())) continue;
                    if (temp > result)
                    {
                        result = temp;
                    }
                }
            }

            Console.WriteLine("Result: {0}", result);
        }
    }
}