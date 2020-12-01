using System;

namespace Euler_collection.Problems
{
    /*
     * A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
     * a² + b² = c²
     *
     * For example, 3² + 4² = 9 + 16 = 25 = 5².
     *
     * There exists exactly one Pythagorean triplet for which a + b + c = 1000.
     * Find the product abc.
     */
    
    public class P009 : ProblemBase
    {
        protected override void Run()
        {
            var a = 0;
            var b = 0;
            var c = 0;
            bool correct = false;

            for (a = 1; a < 1000 / 3; a++)
            {
                for (b = a; b < 1000 / 2; b++)
                {
                    c = 1000 - a - b;
                    if ((a * a) + (b * b) != c * c) continue;
                    correct = true;
                    break;
                }

                if (correct)
                {
                    break;
                }
            }

            var result = a * b * c;
            
            Console.WriteLine("Result: {0}", result);
        }
    }
}