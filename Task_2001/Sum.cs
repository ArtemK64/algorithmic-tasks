using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_2001
{
    internal class Sum
    {
        public void calcSumOfNumbersFromFile()
        {
            using(StreamReader reader = new StreamReader("input.txt"))
            {
                string fileContent = reader.ReadToEnd();

                if (fileContent.Length == 0)
                {
                    Console.WriteLine("File is empty");
                }

                MatchCollection matches = Regex.Matches(fileContent, @"\d+");
                int sum = 0;
                foreach (Match match in matches)
                {
                    sum += int.Parse(match.Value);
                }

                using (StreamWriter writer = new StreamWriter("output.txt"))
                {
                    writer.WriteLine(sum);
                }
            }
        }
    }
}
