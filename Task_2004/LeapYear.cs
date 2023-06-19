using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2004
{
    internal class LeapYear
    {
        public void getLeapYear()
        {
            string inputFileName = "input.txt";
            using (StreamReader reader = new StreamReader(inputFileName))
            {
                bool isLeap = false;
                int inputYear = int.Parse(reader.ReadToEnd());
                if ((inputYear % 4 == 0 && inputYear % 100 != 0) || inputYear % 400 == 0)
                {
                    isLeap = true;
                }

                string outputFileName = "output.txt";
                using (StreamWriter writer = new StreamWriter(outputFileName))
                {
                    if (isLeap)
                    {
                        writer.WriteLine(1);
                    }
                    else
                    {
                        writer.WriteLine(0);
                    }
                    
                }
            }
        }
    }
}
