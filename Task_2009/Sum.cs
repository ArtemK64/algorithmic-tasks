using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2009
{
    internal class Sum
    {
        public void CalcSumOfMathPowTwoPosition() 
        {
            string[] lines = File.ReadAllLines("input.txt");
            int qtyOfNumbers = int.Parse(lines[0]);
            string[] numbers = lines[1].Split(" ");
            int sum = 0;

            for (int i = 0; i < qtyOfNumbers; i++) 
            {
                int currentNumber = int.Parse(numbers[i]);
                if (((i + 1) & i) == 0)
                {
                    sum += currentNumber;
                }
            }
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine(sum);
            }
        }
    }
}
