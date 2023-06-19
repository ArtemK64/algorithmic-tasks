using System.Diagnostics;

namespace Task_2041
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Palindrome palindrome = new Palindrome();
            palindrome.IsConcatinationOfTwoPalindromes();

            stopwatch.Stop();
            Console.WriteLine("Time: " +  stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}