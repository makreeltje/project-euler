using System;
using System.Diagnostics;

namespace Problem012
{
    class Program
    {
        private static Stopwatch _stopwatch = new Stopwatch();
        static void Main(string[] args)
        {
            _stopwatch.Start();
            var num = 0;
            var i = 1;

            while (numOfDivisors(num) < 500)
            {
                num += i;
                i++;
            }
            
            Console.WriteLine("Result: " + num);
            _stopwatch.Stop();
            Console.WriteLine("Time: " + _stopwatch.Elapsed);
            
        }
        
        static int numOfDivisors(int num)
        {
            int nod = 0;
            int sqrt = (int) Math.Sqrt(num);

            for(int i = 1; i<= sqrt; i++){
                if(num % i == 0){
                    nod += 2;
                }
            }
            if (sqrt * sqrt == num) {
                nod--;
            }
                        
            return nod;
        } 
    }
}