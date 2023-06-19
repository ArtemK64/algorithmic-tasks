namespace Task_2002
{
    internal class Sum
    {
        public void calcSumOfNumbersFromFile()
        {
            string inputFileName = "input.txt";
            using (StreamReader reader = new StreamReader(inputFileName))
            {
                int sum = 0;
                string[] lines = File.ReadAllLines(inputFileName);
                int qtyOfNumbers = int.Parse(lines[0]);
                string[] numbers = lines[1].Split(" ");
                for (int i = 0; i < qtyOfNumbers; i++)
                {
                    sum += int.Parse(numbers[i]);
                }

                string outputFileName = "output.txt";
                using (StreamWriter writer = new StreamWriter(outputFileName))
                {
                    writer.Write(sum);
                }
            }
        }
    }
}