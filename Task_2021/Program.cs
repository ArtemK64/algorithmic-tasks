using System.Diagnostics;

namespace Task_2021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            DivideMaximum divideMaximum = new DivideMaximum();
            divideMaximum.ReadAndReturnChangedArray();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}