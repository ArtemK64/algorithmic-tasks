using System.Diagnostics;
using System.Net.Http.Headers;

namespace Task_2037
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            ShortStrings shortStrings = new ShortStrings();
            shortStrings.WriteWordsToFile();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}