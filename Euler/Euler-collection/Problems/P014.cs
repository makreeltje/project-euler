using System;

namespace Euler_collection.Problems
{
    /*
     * The following iterative sequence is defined for the set of positive integers:
     *
     * n → n/2 (n is even)
     * n → 3n + 1 (n is odd)
     *
     * Using the rule above and starting with 13, we generate the following sequence:
     *
     * 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
     *
     * It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not
     * been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
     *
     * Which starting number, under one million, produces the longest chain?
     *
     * NOTE: Once the chain starts the terms are allowed to go above one million.
     */

    public class P014 : ProblemBase
    {
        protected override void Run()
        {
            const int number = 1000000;

            var sequenceLength = 0L;
            var result = 0L;

            for (var i = 2; i <= number; i++)
            {
                var length = 1;
                long sequence = i;
                while (sequence != 1)
                {
                    if ((sequence % 2) == 0)
                        sequence /= 2;
                    else
                    {
                        sequence *= 3;
                        sequence += 1;
                    }
                    length++;
                }

                if (length <= sequenceLength) continue;
                sequenceLength = length;
                result = i;
            }

            Console.WriteLine("Result: {0}", result);
        }
    }
}