using System.Diagnostics;
using System.Net.Http.Headers;

namespace Task_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Palindrome palindrome = new Palindrome();
            palindrome.QtyOfNumbersToBecomePalindrome();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}