namespace Task_2024
{
    internal class Palindrome
    {
        public void QtyOfNumbersToBecomePalindrome()
        {
            string[] lines = File.ReadAllLines("input.txt");
            int qtyOfNumbers = int.Parse(lines[0]);
            int[] numbers = Array.ConvertAll(lines[1].Split(" "), int.Parse);
            int count = 0;
            for (int i = 0; i < qtyOfNumbers / 2; i++)
            {
                if (numbers[i] != numbers[qtyOfNumbers - i - 1])
                {
                    count++;
                }
            }
            
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine(count);
            }
        }
    }
}