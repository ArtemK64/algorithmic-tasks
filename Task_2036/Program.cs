using System.Diagnostics;

namespace Task_2036
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            StrangeWords strangeWords = new StrangeWords();
            strangeWords.DeleteStrangeWordFromFile();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}