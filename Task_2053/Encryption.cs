namespace Task_2053
{
    internal class Encryption
    {
        public void PrintEncryptedTextAsNumericSequence()
        {
            string[] words = File.ReadAllText("input.txt").Split(new string [] { Environment.NewLine, " " }, StringSplitOptions.None);

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i].ToLower();
                if (!dictionary.ContainsKey(currentWord))
                {
                    dictionary[currentWord] = dictionary.Count + 1;
                }
                words[i] = dictionary[currentWord].ToString();
            }

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine(string.Join(" ", words));
            }
        }
    }
}