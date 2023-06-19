using System.Diagnostics;

namespace Task_2012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            SquareCut squareCut = new SquareCut();
            squareCut.WasCut();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms"); 
        }
    }
}