using System.Diagnostics;

namespace Task_2017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Divisors divisors = new Divisors();
            divisors.FindMaxQtyOfDevisors();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}