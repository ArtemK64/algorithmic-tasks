namespace Task_2019
{
    internal class TriangularShelf
    {
        public void GetNumberOfShelf()
        {
            string[] lines = File.ReadAllLines("input.txt");
            int inputNumber = int.Parse(lines[0]);

            int shelfNumber = 1;
            int count = 1;

            while (inputNumber > count)
            {
                shelfNumber++;
                count += shelfNumber;
            }

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine(shelfNumber);
            }
        }
    }
}