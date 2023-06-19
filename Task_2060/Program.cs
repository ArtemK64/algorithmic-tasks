using System.Diagnostics;

namespace Task_2060
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            RatingAccountingSystem ratingAccountingSystem = new RatingAccountingSystem();
            ratingAccountingSystem.GetNamesAndAvgPoints();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}