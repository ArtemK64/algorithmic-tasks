using System.Diagnostics;

namespace Task_2007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            BinaryZeros binaryZeros = new BinaryZeros();
            binaryZeros.CountBinaryZeros();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}