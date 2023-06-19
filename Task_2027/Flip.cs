namespace Task_2027
{
    internal class Flip
    {
        public void FlipSubarray()
        {
            string[] lines = File.ReadAllLines("input.txt");
            int qtyOfNumbers = int.Parse(lines[0]);
            int[] numbers = Array.ConvertAll(lines[1].Split(" "), int.Parse);
            string[] firstRange = lines[2].Split(" ");
            string[] secondRange = lines[3].Split(" ");
            int l1 = int.Parse(firstRange[0]);
            int r1 = int.Parse(firstRange[1]);
            int l2 = int.Parse(secondRange[0]);
            int r2 = int.Parse(secondRange[1]);

            FlipArray(l1 - 1, r1 - 1, numbers);
            FlipArray(l2 - 1, r2 - 1, numbers);

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine(string.Join(" ", numbers));
            }
        }

        private int[] FlipArray(int firstIndex, int lastIndex, int[] numbers)
        {
            for (int i = 0; i <= (lastIndex - firstIndex) / 2; i++)
            {
                int temp = numbers[i + firstIndex];
                numbers[i + firstIndex] = numbers[lastIndex - i];
                numbers[lastIndex - i] = temp;
            }
            return numbers;
        }
    }
}