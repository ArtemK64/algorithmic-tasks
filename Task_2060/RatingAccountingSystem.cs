namespace Task_2060
{
    internal class RatingAccountingSystem
    {
        public void GetNamesAndAvgPoints()
        {
            string[] lines = File.ReadAllLines("input.txt");
            int qtyOfItems = int.Parse(lines[0]);

            var data = new Dictionary<string, Tuple<int, int>>();

            for (int i = 0; i < qtyOfItems; i++)
            {
                string[] input = lines[i + 1].Split();
                string name = input[0];
                int grade = int.Parse(input[1]);

                if (!data.ContainsKey(name))
                {
                    data[name] = Tuple.Create(grade, 1);
                }
                else
                {
                    int sum = data[name].Item1 + grade;
                    int count = data[name].Item2 + 1;
                    data[name] = Tuple.Create(sum, count);
                }
            }

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                foreach (string name in SortedKeys(data))
                {
                    int avgGrade = data[name].Item1 / data[name].Item2;
                    writer.WriteLine(name + " " + avgGrade);
                }
            }
        }

        private static IEnumerable<string> SortedKeys(Dictionary<string, Tuple<int, int>> dict)
        {
            var keys = new List<string>(dict.Keys);
            keys.Sort();
            return keys;
        }
    }
}