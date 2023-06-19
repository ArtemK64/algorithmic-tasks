using System.Diagnostics;

namespace Task_2051
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Parenthesis parenthesis = new Parenthesis();
            parenthesis.NumberOfPairsOfBracketsInTheInputString();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}