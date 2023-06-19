using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2006
{
    internal class LengthsMeasuring
    {
        public void getInches()
        {
            string inputFileName = "input.txt";
            string[] lines = File.ReadAllLines(inputFileName);
            int inputNumber = int.Parse(lines[0]);

            int inches = (int) Math.Round(inputNumber / 3.0);
            int feet = (int) Math.Round(inches / 12.0);

            inches -= feet * 12;

            string outputFileName = "output.txt";
            using (StreamWriter writer = new StreamWriter(outputFileName))
            {
                writer.Write(feet + " " + inches);
            }
        }
    } 
}