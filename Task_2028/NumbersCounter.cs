namespace Task_2028
{
    internal class NumbersCounter
    {
        public void CountNumbersInArray()
        {
            string[] lines = File.ReadAllLines("input.txt");
            int qtyOfNumbers = int.Parse(lines[0]);
            int[] numbers = Array.ConvertAll(lines[1].Split(" "), int.Parse);

            Dictionary<int, int> pair = new Dictionary<int, int>();

            foreach (int number in numbers)
            {
                if (pair.ContainsKey(number))
                {
                    pair[number]++;
                }
                else
                {
                    pair[number] = 1;
                }
            }

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                for (int i = 0; i <= 4; i++)
                {
                    if (pair.ContainsKey(i))
                    {
                        writer.WriteLine("{0} {1}", i, pair[i]);
                    }
                }
            }
        }
    }
}
