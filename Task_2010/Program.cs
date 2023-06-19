using System.Diagnostics;

namespace Task_2010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            EuclidsAlgorithm algorithm = new EuclidsAlgorithm();
            algorithm.getGreatestCommonDivisor();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        } 
    }
}