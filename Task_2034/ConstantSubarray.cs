namespace Task_2034
{
    internal class ConstantSubarray
    {
        public void FindRangeOfLongestConstantSubarray()
        {
            string[] lines = File.ReadAllLines("input.txt");
            int qtyOfNumbers = int.Parse(lines[0]);
            int[] numbers = Array.ConvertAll(lines[1].Split(" "), int.Parse);

            int maxLen = 0;
            int startIndex = -1;
            int endIndex = -1;

            for (int i = 0; i < qtyOfNumbers; i++)
            {
                int j = i;
                while (j < qtyOfNumbers && Math.Abs(numbers[j] - numbers[i]) <= 1)
                {
                    j++;
                }

                if (j - i > maxLen)
                {
                    maxLen = j - i;
                    startIndex = i;
                    endIndex = j - 1;
                }
            }

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine($"{startIndex + 1} {endIndex + 1}");
            }
        }
    }
}