using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = 0;
            for (int i = 999; i > 100; i--)
            {
                for (int j = 999; j > 100; j--)
                {
                    var temp = i * j;
                    if (temp.ToString() == new string(temp.ToString().Reverse().ToArray()))
                    {
                        if (temp > result)
                        {
                            result = temp;
                        }
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}