namespace Task_2021
{
    internal class DivideMaximum
    {
        public void ReadAndReturnChangedArray()
        {
            string[] lines = File.ReadAllLines("input.txt");
            int[] numbers = Array.ConvertAll(lines[1].Split(" "), int.Parse);
            
            DivideMaximumNumbersInArray(numbers);
            DivideMaximumNumbersInArray(numbers);

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                foreach (int number in numbers)
                {
                    writer.Write(number + " ");
                }
            }
        }

        private void DivideMaximumNumbersInArray(int[] numbers) 
        {
            int max = numbers.Max();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == max)
                {
                    numbers[i] = max / 2;
                }
            }
        }
    }
}