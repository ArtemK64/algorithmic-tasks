using System.Diagnostics;
using System.Net.Http.Headers;

namespace Task_2042
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            SampleSearch search = new SampleSearch();
            search.AllPositionsOfTemplateOccurrenceInText();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}