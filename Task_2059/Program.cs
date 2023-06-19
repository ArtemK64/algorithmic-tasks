using System.Diagnostics;

namespace Task_2059
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            SequenceReplacement sequence = new SequenceReplacement();
            sequence.ArrayAfterAllReplacements();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}