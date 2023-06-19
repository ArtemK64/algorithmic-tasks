namespace Task_2047
{
    internal class CenterAlignment
    {
        public void FormatedText()
        {
            string[] lines = File.ReadAllLines("input.txt");

            int max = 0;
            foreach (string line in lines)
            {
                if (line.Length > max)
                {
                    max = line.Length;
                }
            }

            int numRows = lines.Length + 2;

            char[,] grid = new char[numRows, max + 4];

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < max + 4; j++)
                {
                    if (i == 0 || i == numRows - 1 || j == 0 || j == max + 3)
                    {
                        grid[i, j] = '*';
                    }
                    else
                    {
                        grid[i, j] = ' ';
                    }
                }
            }

            int row = 1;
            foreach (string line in lines)
            {
                int leftSpaces = (max - line.Length) / 2;
                int rightSpaces = max - line.Length - leftSpaces;
                int col = 2 + leftSpaces;
                for (int i = 0; i < line.Length; i++)
                {
                    grid[row, col] = line[i];
                    col++;
                }
                row++;
            }

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < numRows; i++)
                {
                    for (int j = 0; j < max + 4; j++)
                    {
                        writer.Write(grid[i, j]);
                    }
                    writer.WriteLine();
                }
            }
        }
    }
}