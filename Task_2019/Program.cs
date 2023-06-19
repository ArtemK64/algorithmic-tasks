using System.Diagnostics;

namespace Task_2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            TriangularShelf triangularShelf = new TriangularShelf();
            triangularShelf.GetNumberOfShelf();

            stopwatch.Stop();
            Console.WriteLine("Time: " +  stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}