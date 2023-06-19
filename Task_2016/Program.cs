using System.Diagnostics;

namespace Task_2016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            RootEquation equation = new RootEquation();
            equation.getQtyOfRoots();

            stopwatch.Stop();
            Console.WriteLine("Time: " +  stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}