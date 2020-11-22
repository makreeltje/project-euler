using System;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int squareNumber = 0;
            for (int i = 1; i < 101; i++)
            {
                number += i * i;
                squareNumber += i;
            }

            var result = (squareNumber * squareNumber) - number;
            
            Console.WriteLine(result);
        }
    }
}