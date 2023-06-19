namespace Task_2037
{
    internal class ShortStrings
    {
        public void WriteWordsToFile()
        {
            string[] lines = File.ReadAllLines("input.txt");
            string[] words = RemoveExtraSpaces(lines[0].Replace(",", " ").Trim()).Split();
            int lengthOfWordsToDelete = int.Parse(lines[1]);

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.Write(DeleteWordsWithInputLength(words, lengthOfWordsToDelete));
            }
        }

        private string RemoveExtraSpaces(string inputString)
        {
            while (inputString.Contains("  ")) 
            {
                inputString = inputString.Replace("  ", " ");
            }
            return inputString;
        }

        private string DeleteWordsWithInputLength(string[] words, int intputLength)
        {
            List<string> result = new List<string>();
            foreach (string word in words)
            {
                if (word.Length >= intputLength) 
                {
                    result.Add(word);
                }
            }
            return string.Join(",", result);
        }
    }
}