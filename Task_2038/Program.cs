using System.Diagnostics;

namespace Task_2038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            LongestWord longestWord = new LongestWord();
            longestWord.GetLengthOfLongestWord();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}