using System.Diagnostics;

namespace Task_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            SearchArray searchArray = new SearchArray();
            searchArray.GetResultArray();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        } 
    }
}