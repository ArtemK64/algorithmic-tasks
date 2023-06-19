namespace Task_2036
{
    internal class StrangeWords
    {
        public void DeleteStrangeWordFromFile()
        {
            string[] lines = File.ReadAllLines("input.txt");
            int qtyOfNumbers = int.Parse(lines[0]);
            
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < qtyOfNumbers; i++)
                {
                    string currentWord = lines[i + 1];
                    if (!IsStrangeWord(currentWord)) 
                    {
                        writer.WriteLine(currentWord);
                    }
                }
            }
        }

        private bool IsStrangeWord(string word)
        {
            int count = 0;
            foreach (char c in word)
            {
                if ("aeiouy".Contains(c))
                {
                    count++;
                    if (count >= 3)
                    {
                        return true;
                    }
                }
                else
                {
                    count = 0;
                }
            }
            return false;
        }
    }
}
