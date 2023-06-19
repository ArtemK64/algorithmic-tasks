namespace Task_2051
{
    internal class Parenthesis
    {
        public void NumberOfPairsOfBracketsInTheInputString()
        {
            string inputString = File.ReadAllText("input.txt");

            Stack<int> stack = new Stack<int>();
            List<Tuple<int, int>> pairs = new List<Tuple<int, int>>();

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == '(')
                {
                    stack.Push(i + 1);
                }
                else
                {
                    int openPosition = stack.Pop();
                    int closePosition = i + 1;
                    pairs.Add(new Tuple<int, int>(openPosition, closePosition));
                }
            }

            pairs.Sort((x, y) => x.Item1.CompareTo(y.Item1));

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                foreach (Tuple<int, int> pair in pairs)
                {
                    writer.WriteLine(pair.Item1 + " " + pair.Item2);
                }
            }
        }
    }
}
