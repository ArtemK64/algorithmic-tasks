using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2007
{
    internal class BinaryZeros
    {
        public void CountBinaryZeros()
        {
            string inputFileName = "input.txt";
            string[] lines = File.ReadAllLines(inputFileName);
            int inputNumber = int.Parse(lines[0]);
            int binary = int.Parse(Convert.ToString(inputNumber, 2));

            int count = 0;
            while (binary > 0)
            {
                if (binary % 2 == 0)
                {
                    count++;
                    binary /= 2;
                }
                else
                {
                    break;
                }
            }

            string outputFileName = "output.txt";
            using (StreamWriter writer = new StreamWriter(outputFileName))
            {
                writer.Write(count);
            }
        }
    }
}
