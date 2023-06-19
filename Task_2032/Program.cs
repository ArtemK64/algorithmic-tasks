using System.Diagnostics;

namespace Task_2032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            CompareLongNumbers compareLongNumbers = new CompareLongNumbers();
            compareLongNumbers.CompareTwoArrays();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}