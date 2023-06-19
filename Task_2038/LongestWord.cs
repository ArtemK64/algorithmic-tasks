namespace Task_2038
{
    internal class LongestWord
    {
        public void GetLengthOfLongestWord()
        {
            string[] lines = File.ReadAllLines("input.txt");
            string inputString = lines[0];

            int maxLength = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                int wordLength = 0;

                while (i < inputString.Length && !IsLetter(inputString[i]))
                {
                    i++;
                }

                while (i < inputString.Length && IsLetter(inputString[i]))
                {
                    wordLength++;
                    i++;
                }

                if (wordLength > maxLength)
                {
                    maxLength = wordLength;
                }
            }
        
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine(maxLength);        
            }
        }

        private static bool IsLetter(char letter)
        {
            return (letter >= 'a' && letter <= 'z') || (letter >= 'A' && letter <= 'Z');
        }
    }
}