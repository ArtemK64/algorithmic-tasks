namespace Task_2018
{
    internal class TrickySum
    {
        public void FindTrickySum()
        {
            string[] lines = File.ReadAllLines("input.txt");
            int qtyOfNumbers = int.Parse(lines[0]);
            string[] numbers = lines[1].Split(" ");

            int sum = 0;
            int index = 0;
            int group = 1;
            bool sign = true;
            for (int i = 0; i < qtyOfNumbers; i++)
            {
                int currentNumber = int.Parse(numbers[i]);
                if (sign)
                {
                    sum += currentNumber;
                }
                else
                {
                    sum -= currentNumber;
                }

                index++;

                if (index >= group)
                {
                    index = 0;
                    group++;
                    sign = !sign;
                }
            }

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine(sum);
            }
        }
    }
}