using System.Text;

namespace Task_2039
{
    internal class TextWords
    {
        public void CalcQtyOfWords()
        {
            string[] lines = File.ReadAllLines("input.txt");
            string inputString = lines[0];
            List<string> words = new List<string>();

            for (int i = 0; i < inputString.Length; i++)
            {
                StringBuilder word = new StringBuilder();
                while (i < inputString.Length && !IsLetter(inputString[i]))
                {
                    i++;
                }

                while (i < inputString.Length && IsLetter(inputString[i]))
                {
                    word.Append(inputString[i]);
                    i++;
                }

                if (word.Length > 0)
                {
                    words.Add(word.ToString());
                }
            }

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine(words.Count);
            }
        }

        private bool IsLetter(char letter)
        {
            return (letter >= 'a' && letter <= 'z') || (letter >= 'A' && letter <= 'Z');
        }
    }
}