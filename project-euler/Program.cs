using System;
namespace Problem1
{
    public class Program
    {
        public static project_euler.Problems.Problem1 _problem1 = new project_euler.Problems.Problem1();
        static void Main(string[] args)
        {
            Console.WriteLine("The multiples of 3 and 5 till 1000 are: " + _problem1.Main());
        }
    }
}