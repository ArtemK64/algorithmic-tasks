namespace Task_2045
{
    internal class Punctuation
    {
        public void SetSpaces()
        {
            string[] lines = File.ReadAllLines("input.txt");
            string inputString = lines[0];

            string finalString = "";
            for (int i = 0; i < inputString.Length; i++)
            {
                if (Char.IsLetter(inputString[i]))
                {
                    finalString += inputString[i];
                }
                else if (Char.IsPunctuation(inputString[i]))
                {
                    while (finalString.EndsWith(" "))
                    {
                        finalString = finalString.Remove(finalString.Length - 1);
                    }

                    finalString += inputString[i] + " ";
                }
                else if (Char.IsWhiteSpace(inputString[i]))
                {
                    if (!finalString.EndsWith(" "))
                    {
                        finalString += inputString[i];
                    }
                }
            }

            while (finalString.EndsWith(" "))
            {
                finalString = finalString.Remove(finalString.Length - 1);
            }

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine(finalString);
            }
        }
    }
}