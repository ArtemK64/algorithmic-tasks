using System.Drawing;

namespace Task_2062
{
    internal class PointExpansion
    {
        public void PrintCoordOfAllPoints()
        {
            string[] lines = File.ReadAllLines("input.txt");
            string[] input = lines[0].Split();
            int qtyOfPoints = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            HashSet<Point> points = new HashSet<Point>();

            for (int i = 0; i < qtyOfPoints; i++)
            {
                string[] line = lines[i + 1].Split();
                int x = int.Parse(line[0]);
                int y = int.Parse(line[1]);
                points.Add(new Point(x, y));
            }

            for (int i = 0; i < k; i++)
            {
                HashSet<Point> tempPoints = new HashSet<Point>();
                foreach (Point p in points)
                {
                    tempPoints.Add(new Point(p.X + 1, p.Y));
                    tempPoints.Add(new Point(p.X - 1, p.Y));
                    tempPoints.Add(new Point(p.X, p.Y + 1));
                    tempPoints.Add(new Point(p.X, p.Y - 1));
                }
                points.UnionWith(tempPoints);
            }

            List<Point> sortedPoints = new List<Point>(points);
            sortedPoints.Sort((a, b) => a.X == b.X ? a.Y.CompareTo(b.Y) : a.X.CompareTo(b.X));
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                foreach (Point p in sortedPoints)
                {
                    writer.WriteLine(p.X + " " + p.Y);
                }
            }
        }
    }
}