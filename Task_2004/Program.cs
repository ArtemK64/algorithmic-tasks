using System.Diagnostics;
using System.Net.Http.Headers;

namespace Task_2004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            LeapYear leapYear = new LeapYear();
            leapYear.getLeapYear();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}