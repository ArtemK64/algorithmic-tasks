namespace Task_2025
{
    internal class RangeMinimumQuery
    {
        public void GetAnswersOnQueries()
        {
            string[] lines = File.ReadAllLines("input.txt");
            int qtyOfNumbersInArray = int.Parse(lines[0]);
            int[] numbers = Array.ConvertAll(lines[1].Split(" "), int.Parse);
            int qtyOfQueries = int.Parse(lines[2]);
            
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < qtyOfQueries; i++)
                {
                    string[] currentQueryArray = lines[i + 3].Split(" ");
                    int l = int.Parse(currentQueryArray[0]) - 1;
                    int r = int.Parse(currentQueryArray[1]) - 1;
                    int min = int.MaxValue;
                    for (int j = l; j <= r; j++)
                    {
                        if (numbers[j] < min)
                        {
                            min = numbers[j];
                        }
                    }
                    writer.WriteLine(min);
                }
            }
        }
    }
}