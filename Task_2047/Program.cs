using System.Diagnostics;

namespace Task_2047
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            CenterAlignment centerAlignment = new CenterAlignment();
            centerAlignment.FormatedText();

            stopwatch.Stop();
            Console.WriteLine("Time: " +  stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}