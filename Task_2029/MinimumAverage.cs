namespace Task_2029
{
    internal class MinimumAverage
    {
        public void CalcMinimumAveragePosition()
        {
            string[] lines = File.ReadAllLines("input.txt");
            int qtyOfNumbers = int.Parse(lines[0]);
            int[] numbers = Array.ConvertAll(lines[1].Split(" "), int.Parse);

            int min = int.MaxValue;
            int count = 0;
            int[] positions = new int[qtyOfNumbers];
            int index = 0;

            for (int i = 0; i < qtyOfNumbers; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    count = 1;
                    positions[index] = i;
                    index = 1;
                }
                else if (numbers[i] == min)
                {
                    count++;
                    positions[index] = i;
                    index++;
                }
            }

            int middleIndex = count % 2 == 0 ? count / 2 - 1 : count / 2;

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.Write(positions[middleIndex] + 1);
            }
        }
    }
}