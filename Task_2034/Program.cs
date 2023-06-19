using System.Diagnostics;

namespace Task_2034
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            ConstantSubarray constantSubarray = new ConstantSubarray();
            constantSubarray.FindRangeOfLongestConstantSubarray();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}