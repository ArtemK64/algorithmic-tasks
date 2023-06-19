namespace Task_2052
{
    internal class CrossNumbers
    {
        public void PrintSequenceAfterApplyingAllOperations()
        {
            string[] lines = File.ReadAllLines("input.txt");
            string[] firstLine = lines[0].Split();
            int qtyOfNumbers = int.Parse(firstLine[0]);
            int k = int.Parse(firstLine[1]);

            int[] a = Array.ConvertAll(lines[1].Split(" "), int.Parse);
            int[] b = Array.ConvertAll(lines[2].Split(" "), int.Parse);

            int[] result = Enumerable
                .Range(1, qtyOfNumbers)
                .Where(i => !Enumerable.Range(0, k).Any(j => i % b[j] == 0))
                .Select(i => a[i - 1])
                .ToArray();


            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine(string.Join(" ", result));
            }
        }
    }
}
