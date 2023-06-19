using System.Diagnostics;

namespace Task_2028
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            NumbersCounter counter = new NumbersCounter();
            counter.CountNumbersInArray();

            stopwatch.Stop();
            Console.WriteLine("Time: " +  stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}