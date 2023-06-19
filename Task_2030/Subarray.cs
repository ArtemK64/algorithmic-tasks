namespace Task_2030
{
    internal class Subarray
    {
        public void QtyOfPairsWithNullSum()
        {
            string[] lines = File.ReadAllLines("input.txt");
            int qtyOfNumbers = int.Parse(lines[0]);
            int[] numbers = Array.ConvertAll(lines[1].Split(" "), int.Parse);

            int count = 0;
            for (int i = 0; i < qtyOfNumbers; i++)
            {
                int sum = 0;
                for (int j = i; j < qtyOfNumbers; j++)
                {
                    sum += numbers[j];
                    if (sum == 0)
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