using System;
using System.Diagnostics;

namespace Euler_collection
{
    public abstract class ProblemBase
    {
        public void Execute()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Run();
            stopwatch.Stop();
            Console.WriteLine("Time:   {0:ss\':\'fffffff}", stopwatch.Elapsed);
        }

        protected abstract void Run();
    }
}