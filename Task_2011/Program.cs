using System.Diagnostics;

namespace Task_2011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            AgeAnalysis ageAnalysis = new AgeAnalysis();
            ageAnalysis.GetAgeResult();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}