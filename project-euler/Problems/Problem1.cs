using System;

namespace project_euler.Problems
{
    public class Problem1
    {
        public int Main()
        {
            var sum = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }

            return sum;
        }
    }
}