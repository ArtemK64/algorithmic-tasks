using System.Diagnostics;

namespace Task_2029
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            MinimumAverage minimumAverage = new MinimumAverage();
            minimumAverage.CalcMinimumAveragePosition();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}