namespace Task_2040
{
    internal class CyclicShift
    {
        public void ReadAndWriteResultSting()
        {
            string[] lines = File.ReadAllLines("input.txt");

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine(GetSmallestRotation(lines[0]));
            }
        }

        public string GetSmallestRotation(string inputString)
        {
            string doubleInputString = inputString + inputString;

            int i = 0;
            for (int j = 1; j < inputString.Length; j++)
            {
                int k = 0;
                while (k < inputString.Length && doubleInputString[i + k] == doubleInputString[j + k])
                {
                    k++;
                }
                if (doubleInputString[i + k] > doubleInputString[j + k])
                {
                    i = j;
                }
            }

            return doubleInputString.Substring(i, inputString.Length);
        }
    }
}