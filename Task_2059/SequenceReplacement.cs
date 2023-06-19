namespace Task_2059
{
    internal class SequenceReplacement
    {
        public void ArrayAfterAllReplacements()
        {
            string[] lines = File.ReadAllLines("input.txt");
            int n = int.Parse(lines[0]);
            int[] numbers = Array.ConvertAll(lines[1].Split(), int.Parse);

            var deque = new LinkedList<int>();
            int[] res = new int[n];

            for (int i = 0; i < n; i++)
            {
                while (deque.Count > 0 && numbers[deque.Last.Value] <= numbers[i])
                {
                    deque.RemoveLast();
                }
                if (deque.Count == 0)
                {
                    res[i] = -1;
                }
                else
                {
                    res[i] = numbers[deque.Last.Value];
                }
                deque.AddLast(i);
            }

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine(string.Join(" ", res));
            }
        }
    }
}
