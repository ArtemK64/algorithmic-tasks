using System.Diagnostics;

namespace Task_2015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            PrimeNumber primeNumber = new PrimeNumber();
            primeNumber.GetPrimeNumbers();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}