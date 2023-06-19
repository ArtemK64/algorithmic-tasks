namespace Task_2054
{
    internal class Sequence
    {
        public void WhichSequencesOccursNumber()
        {
            string[] lines = File.ReadAllLines("input.txt");
            int qtyOfSequences = int.Parse(lines[0]);
            Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
            for (int i = 1; i <= qtyOfSequences; i++)
            {
                string[] input = lines[i].Split();
                int k = int.Parse(input[0]);
                for (int j = 1; j <= k; j++)
                {
                    int x = int.Parse(input[j]);
                    if (!dictionary.ContainsKey(x))
                    {
                        dictionary[x] = new List<int>();
                    }
                    dictionary[x].Add(i);
                }
            }
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                foreach (KeyValuePair<int, List<int>> item in dictionary)
                {
                    writer.Write(item.Key + " ");
                    foreach (int seq in item.Value)
                    {
                        writer.Write(seq + " ");
                    }
                    writer.WriteLine();
                }
            }
        }
    }
}