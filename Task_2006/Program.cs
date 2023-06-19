using System.Diagnostics;
using System.Net.Http.Headers;

namespace Task_2006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            LengthsMeasuring lengthsMeasuring = new LengthsMeasuring();
            lengthsMeasuring.getInches();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}