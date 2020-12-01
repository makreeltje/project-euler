using System;
using Euler_collection.Problems;

namespace Euler_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("Enter problem number: ");
                var problemNumber =  "Euler_collection.Problems.P" + Console.ReadLine()?.PadLeft(3,'0');
                var type = Type.GetType(problemNumber);

                if (type == null)
                {
                    Console.WriteLine("Problem doesn't exist");
                    continue;
                }
                
                var instance = Activator.CreateInstance(type);
                var problemBase = (ProblemBase) instance;
                problemBase.Execute();
            }
        }
    }
}