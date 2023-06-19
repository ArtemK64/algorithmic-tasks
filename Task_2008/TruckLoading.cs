namespace Task_2008
{
    internal class TruckLoading
    {
        public void Load()
        {
            string inputFileName = "input.txt";
            string[] lines = File.ReadAllLines(inputFileName);
            string[] firstRow = lines[0].Split(" ");
            int qtyOfNumbers = int.Parse(firstRow[0]);
            int loadCapacity = int.Parse(firstRow[1]);
            string[] numbers = lines[1].Split(" ");
            int count = 0;
            int sum = 0;

            for (int i = 0; i < qtyOfNumbers; i++)
            {
                int currentNumber = int.Parse(numbers[i]);
                if (loadCapacity - currentNumber >= 0)
                {
                    loadCapacity -= currentNumber;
                    sum += currentNumber;
                    count++;
                }
            }

            string outputFileName = "output.txt";
            using (StreamWriter writer = new StreamWriter(outputFileName))
            {
                writer.Write(count + " " + sum);
            }
        }
    }
}