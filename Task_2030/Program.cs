using System.Diagnostics;

namespace Task_2030
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Subarray subarray = new Subarray();
            subarray.QtyOfPairsWithNullSum();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}