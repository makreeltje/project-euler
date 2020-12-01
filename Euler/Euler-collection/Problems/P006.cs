using System;

namespace Euler_collection.Problems
{
    /*
     * The sum of the squares of the first ten natural numbers is,
     * 1² + 2² + ... + 10² = 385
     * 
     * The square of the sum of the first ten natural numbers is,
     * (1 + 2 + ... 10)² = 55² = 3025
     * 
     * Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is
     * 3025 - 385 = 2640
     *
     * Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
     */
    
    public class P006 : ProblemBase
    {
        protected override void Run()
        {
            var number = 0;
            var squareNumber = 0;
            
            for (var i = 1; i < 101; i++)
            {
                number += i * i;
                squareNumber += i;
            }

            var result = (squareNumber * squareNumber) - number;
            
            Console.WriteLine("Result: {0}", result);
        }
    }
}