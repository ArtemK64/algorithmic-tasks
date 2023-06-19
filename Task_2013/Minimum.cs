using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2013
{
    internal class Minimum
    {
        public void GetQtyOfMinimumElements()
        {
            string[] lines = File.ReadAllLines("input.txt");
            int qtyOfNumbers = int.Parse(lines[0]);
            string[] numbers = lines[1].Split(" ");
            int min = int.MaxValue;
            int count = 0;

            for (int i = 0; i < qtyOfNumbers; i++)
            {
                int currentNumber = int.Parse(numbers[i]);
                if (currentNumber < min)
                {
                    min = currentNumber;
                }
            }

            for (int i = 0; i < qtyOfNumbers; i++)
            {
                int currentNumber = int.Parse(numbers[i]);
                if (currentNumber == min)
                {
                    count++;
                }
            }

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine(count);
            }
        }
    }
}