namespace Task_2042
{
    internal class SampleSearch
    {
        public void AllPositionsOfTemplateOccurrenceInText()
        {
            string[] lines = File.ReadAllLines("input.txt");
            string inputString = lines[0];
            string pattern = lines[1];

            List<int> resultPositions = new List<int>();
            for (int i = 0; i <= inputString.Length - pattern.Length; i++)
            {
                bool match = true;
                for (int j = 0; j < pattern.Length; j++)
                {
                    if (pattern[j] != '?' && pattern[j] != inputString[i + j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                {
                    resultPositions.Add(i + 1);
                }
            }

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine(string.Join(" ", resultPositions));
            }
        }
    }
}