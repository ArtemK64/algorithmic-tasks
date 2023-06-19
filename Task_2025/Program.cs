using System.Diagnostics;

namespace Task_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            RangeMinimumQuery rangeMinimumQuery = new RangeMinimumQuery();
            rangeMinimumQuery.GetAnswersOnQueries();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}