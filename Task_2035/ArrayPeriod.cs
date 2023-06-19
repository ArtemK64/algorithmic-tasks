namespace Task_2035
{
    internal class ArrayPeriod
    {
        public void GetLengthOfArrayPeriod()
        {
            string[] lines = File.ReadAllLines("input.txt");
            int qtyOfNumbers = int.Parse(lines[0]);
            int[] numbers = Array.ConvertAll(lines[1].Split(" "), int.Parse);

            int periodLength = qtyOfNumbers;
            for (int i = 1; i <= qtyOfNumbers; i++)
            {
                if (qtyOfNumbers % i == 0)
                {
                    bool isPeriodic = true;
                    for (int j = 0; j < qtyOfNumbers - i; j++)
                    {
                        if (numbers[j] != numbers[j + i])
                        {
                            isPeriodic = false;
                            break;
                        }
                    }
                    if (isPeriodic)
                    {
                        periodLength = i;
                        break;
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine(periodLength);
            }
        }
    }
}