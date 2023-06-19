using System.Diagnostics;

namespace Task_2044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            HuffmanAlgorithm huffmanAlgorithm = new HuffmanAlgorithm();
            huffmanAlgorithm.DecodeText();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}