using System.Diagnostics;

namespace Task_2035
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            ArrayPeriod period = new ArrayPeriod();
            period.GetLengthOfArrayPeriod();

            stopwatch.Stop();
            Console.WriteLine("Time: " +  stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}