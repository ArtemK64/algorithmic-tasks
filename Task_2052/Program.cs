using System.Diagnostics;

namespace Task_2052
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            CrossNumbers crossNumbers = new CrossNumbers();
            crossNumbers.PrintSequenceAfterApplyingAllOperations();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}