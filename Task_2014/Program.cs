using System.Diagnostics;

namespace Task_2014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            EuclidsAlgorithm algorithm = new EuclidsAlgorithm();
            algorithm.GetGreatestCommonDivisor();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}