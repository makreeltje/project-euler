using System;

namespace Problem9
{
    class Program
    {
        static void Main(string[] args)
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
                    if ((a * a) + (b * b) == c * c)
                    {
                        correct = true;
                        break;
                    }
                }

                if (correct)
                {
                    break;
                }
            }
            
            Console.WriteLine(a * b * c);
        }
    }
}