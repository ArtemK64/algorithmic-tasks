namespace Task_2031
{
    internal class AntiUniqueNumbers
    {
        public void GetAntiUniqueNumbers()
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

            List<int> result = new List<int>();
            foreach (KeyValuePair<int, int> kvp in pair)
            {
                if (kvp.Value > 1)
                {
                    result.Add(kvp.Key);
                }
            }

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine(result.Count);
                writer.WriteLine(string.Join(" ", result));
            }
        }
    }
}