using System.Diagnostics;

namespace Task_2043
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            
            SimpleXML simpleXML = new SimpleXML();
            simpleXML.RectreateXMLHierarchy();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}