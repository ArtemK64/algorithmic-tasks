namespace Task_2017
{
    internal class Divisors
    {
        public void FindMaxQtyOfDevisors()
        {
            string[] lines = File.ReadAllLines("input.txt");
            string[] firstRow = lines[0].Split(" ");
            int a = int.Parse(firstRow[0]);
            int b = int.Parse(firstRow[1]);

            int max = int.MinValue;
            int count = 0;
            for (int i = a; i <= b; i++)
            {
                if (GetQtyOfDivisors(i) > max)
                {
                    max = GetQtyOfDivisors(i);
                }
            }

            List<int> result = new List<int>();
            for (int i = a; i <= b; i++)
            {
                if (GetQtyOfDivisors(i) == max)
                {
                    result.Add(i);
                    count++;
                }
            }
            string resultString = string.Join(",", result);
            
            using (StreamWriter writer = new StreamWriter("output.txt")) 
            {
                writer.WriteLine(count);
                writer.WriteLine(resultString);
            }
        }

        private int GetQtyOfDivisors(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}