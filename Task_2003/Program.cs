using System.Diagnostics;

namespace Task_2003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            AlternativeSum sum = new AlternativeSum();
            sum.calcAlternativeSumOfNumbersFromFile();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}