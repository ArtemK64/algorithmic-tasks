using System.Diagnostics;

namespace Task_2005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            MinimumNumberPosition minimumNumberPosition = new MinimumNumberPosition();
            minimumNumberPosition.getMinimumNumberPosition();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}