using System.Diagnostics;

namespace Task_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            DividingPair dividingPair = new DividingPair();
            dividingPair.FindQtyOfPairs();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}