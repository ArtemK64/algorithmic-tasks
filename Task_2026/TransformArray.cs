namespace Task_2026
{
    internal class TransformArray
    {
        public void ReplaceWithNextGreatest()
        {
            string[] lines = File.ReadAllLines("input.txt");
            int qtyOfnumbers = int.Parse(lines[0]);
            int[] numbers = Array.ConvertAll(lines[1].Split(" "), int.Parse);

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < qtyOfnumbers; i++)
                {
                    int j = i + 1;
                    while (j < qtyOfnumbers && numbers[j] <= numbers[i]) 
                    {
                        j++;
                    }
                    writer.Write(j < qtyOfnumbers ? numbers[j] + " " : "0 ");
                }
            }
        }
    }
}