namespace Task_2023
{
    internal class SearchArray
    {
        public void GetResultArray()
        {
            string[] lines = File.ReadAllLines("input.txt");
            int qtyOfFirstArray = int.Parse(lines[0]);
            int[] firstArrayNumbers = Array.ConvertAll(lines[1].Split(" "), int.Parse);
            int qtyOfSecondArray = int.Parse(lines[2]);
            int[] secondArrayNumbers = Array.ConvertAll(lines[3].Split(" "), int.Parse);

            //int[] resultArray = firstArrayNumbers.Where(secondArrayNumbers.Contains).ToArray();

            List<int> result = new List<int>();
            foreach (int number in firstArrayNumbers)
            {
                if (secondArrayNumbers.Contains(number))
                {
                    result.Add(number);
                }
            }

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                int qtyOfResultArray = result.Count;
                if (qtyOfResultArray == 0)
                {
                    writer.WriteLine(0);
                }
                else
                {
                    writer.WriteLine(qtyOfResultArray);
                    writer.WriteLine(string.Join(" ", result));
                }
            }
        }
    }
}