using System.Diagnostics;

namespace Task_2053
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Encryption encryption = new Encryption();
            encryption.PrintEncryptedTextAsNumericSequence();

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms"); 
        }
    }
}