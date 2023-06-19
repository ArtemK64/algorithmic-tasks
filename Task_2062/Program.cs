using System.Diagnostics;

namespace Task_2062
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            PointExpansion point = new PointExpansion();
            point.PrintCoordOfAllPoints();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}