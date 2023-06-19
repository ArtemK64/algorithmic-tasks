using System.Diagnostics;

namespace Task_2031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            AntiUniqueNumbers antiUniqueNumbers = new AntiUniqueNumbers();
            antiUniqueNumbers.GetAntiUniqueNumbers();

            stopwatch.Stop();
            Console.WriteLine("Time: " +  stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}