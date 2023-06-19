using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2003
{
    internal class AlternativeSum
    {
        public void calcAlternativeSumOfNumbersFromFile()
        {
            string inputFileName = "input.txt";
            using (StreamReader reader = new StreamReader(inputFileName))
            {
                string[] lines = File.ReadAllLines(inputFileName);

                int sum = 0;
                int qtyOfNumbers = int.Parse(lines[0]);
                string[] numbers = lines[1].Split(" ");

                for (int i = 0; i < qtyOfNumbers; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum += -1 * int.Parse(numbers[i]);
                    }
                    else
                    {
                        sum += int.Parse(numbers[i]);
                    }
                }

                string outputFileName = "output.txt";
                using (StreamWriter writer = new StreamWriter(outputFileName))
                {
                    writer.WriteLine(sum);
                }
            }
        }
    }
}
