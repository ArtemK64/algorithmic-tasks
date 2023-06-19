using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2020
{
    internal class FrequentValue
    {
        public void FindFrequentValue()
        {
            string[] lines = File.ReadAllLines("input.txt");
            int qtyOfNumbers = int.Parse(lines[0]);
            string[] numbers = lines[1].Split(" ");

            int left = 0;
            int right = 0;
            int maxCount = 0;
            int currentCount = 0;
            int maxValue = 0;

            while (right < qtyOfNumbers)
            {
                while (right < qtyOfNumbers && int.Parse(numbers[right]) == int.Parse(numbers[left]))
                {
                    currentCount++;
                    right++;
                }

                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    maxValue = int.Parse(numbers[left]);
                }

                currentCount = 0;

                left = right;
            }

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine(maxValue + " " + maxCount);
            }
        }
    }
}
