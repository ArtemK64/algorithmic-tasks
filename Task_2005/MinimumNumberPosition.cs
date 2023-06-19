using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task_2005
{
    internal class MinimumNumberPosition
    {
        public void getMinimumNumberPosition()
        {
            string inputFileName = "input.txt";
            string[] lines = File.ReadAllLines(inputFileName);
            int qtyOfNumbers = int.Parse(lines[0]);
            string[] numbers = lines[1].Split(" ");
            int min = int.MaxValue;
            int position = 0;

            for (int i = 0; i < qtyOfNumbers - 1; i++)
            {
                int currentNumber = int.Parse(numbers[i]);
                if (currentNumber < min) 
                {
                    min = currentNumber;
                    position = i + 1;
                }
            }

            string outputFileName = "output.txt";
            using (StreamWriter writer = new StreamWriter(outputFileName))
            {
                writer.Write(position);
            }
        }
    }
}
