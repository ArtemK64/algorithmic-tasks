using System.Diagnostics;

namespace Task_2040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            CyclicShift shift = new CyclicShift();
            shift.ReadAndWriteResultSting();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}