using System.Diagnostics;

namespace Task_2033
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            LongNumber longNumber =  new LongNumber();
            longNumber.AddOneToLongNumber();

            stopwatch.Stop();

            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}