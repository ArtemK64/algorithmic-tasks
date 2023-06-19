using System.Diagnostics;
using System.Transactions;

namespace Task_2020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            FrequentValue frequentValue = new FrequentValue();
            frequentValue.FindFrequentValue();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}