namespace Task_2015
{
    internal class PrimeNumber
    {
        public void GetPrimeNumbers()
        {
            string[] lines = File.ReadAllLines("input.txt");
            int inputNumber = int.Parse(lines[0].Split(" ")[0]);

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                for (int i = 2; i < inputNumber; i++)
                {
                    if (IsPrimeNumber(i))
                    {
                        writer.WriteLine(i);
                    }
                }
            }
        }

        private bool IsPrimeNumber(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}