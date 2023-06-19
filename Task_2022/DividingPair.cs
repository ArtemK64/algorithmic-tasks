namespace Task_2022
{
    internal class DividingPair
    {
        public void FindQtyOfPairs()
        {
            string[] lines = File.ReadAllLines("input.txt");
            int qtyOfNumbers = int.Parse(lines[0]);
            int[] numbers = Array.ConvertAll(lines[1].Split(" "), int.Parse);
            int count = 0;

            for (int i = 0; i < qtyOfNumbers; i++)
            {
                for (int j = 0; j < qtyOfNumbers; j++)
                {
                    if (i != j && numbers[i] % numbers[j] == 0)
                    {
                        count++;
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine(count);
            }
        }
    }
}