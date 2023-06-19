namespace Task_2012
{
    internal class SquareCut
    {
        public void WasCut()
        {
            string[] lines = File.ReadAllLines("input.txt");
            string[] firstRow = lines[0].Split(" ");
            string[] secondRow = lines[1].Split(" ");
            int a1 = int.Parse(firstRow[0]);
            int b1 = int.Parse(firstRow[1]);
            int a2 = int.Parse(secondRow[0]);
            int b2 = int.Parse(secondRow[1]);

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                int size = Math.Max(a1, Math.Max(b1, Math.Max(a2, b2)));

                if ((a1 == size && b2 == size && a2 + b1 == size) ||
                    (a1 == size && a2 == size && b1 + b2 == size) ||
                    (b1 == size && b2 == size && a1 + a2 == size) ||
                    (b1 == size && a2 == size && a1 + b2 == size))
                {
                    writer.WriteLine("YES");
                }
                else
                {
                    writer.WriteLine("NO");
                }
            }
        }
    }
}
