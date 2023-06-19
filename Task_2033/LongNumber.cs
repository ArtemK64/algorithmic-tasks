using System;

namespace Task_2033
{
    internal class LongNumber
    {
        public void AddOneToLongNumber()
        {
            string[] lines = File.ReadAllLines("input.txt");
            int inputNumber = int.Parse(lines[1].Replace(" ", ""));
            char[] digitsOfResultNumber = (inputNumber + 1).ToString().ToCharArray();

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine(digitsOfResultNumber.Length);
                writer.Write(string.Join(" ", digitsOfResultNumber));
            }
        }
    }
}