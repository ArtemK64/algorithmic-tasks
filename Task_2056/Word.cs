namespace Task_2056
{
    internal class Word
    {
        public void PrintTheMostPopularWord()
        {
            string[] words = File.ReadAllText("input.txt")
                .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(w => w.ToLower())
                .ToArray();

            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }

            int maxCount = counts.Values.Max();

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                foreach (string word in counts.Keys.OrderBy(w => w))
                {
                    if (counts[word] == maxCount)
                    {
                        writer.WriteLine(word);
                    }
                }
            }
        }
    }
}
