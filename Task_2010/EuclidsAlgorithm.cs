using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_2010
{
    internal class EuclidsAlgorithm
    {
        public void getGreatestCommonDivisor()
        {
            string[] lines = File.ReadAllLines("input.txt");
            string[] numbers = lines[0].Split(" ");

            int firstNumber = int.Parse(numbers[0]);
            int secondNumber = int.Parse(numbers[1]);

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                int qtyOfOperations = 0;
                while (secondNumber != 0)
                {
                    int temp = secondNumber;
                    secondNumber = firstNumber % secondNumber;
                    firstNumber = temp;
                    qtyOfOperations++;
                }

                writer.WriteLine(qtyOfOperations + " " + firstNumber);
            }
        }
    }
}