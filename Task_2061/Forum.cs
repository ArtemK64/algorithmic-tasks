namespace Task_2061
{
    internal class Forum
    {
        private static Dictionary<string, List<string>> tree = new Dictionary<string, List<string>>();

        public void ReadFile()
        {
            string[] lines = File.ReadAllLines("input.txt");
            int qtyOfSections = int.Parse(lines[0]);
            for (int i = 1; i < qtyOfSections; i++)
            {
                string[] parts = lines[i].Split();
                string child = parts[0];
                string parent = parts[1];
                if (!tree.ContainsKey(parent))
                {
                    tree[parent] = new List<string>();
                }
                tree[parent].Add(child);
            }

            List<string> result = new List<string>();
            PrintTree("main", 0, result);

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                foreach (string line in result)
                {
                    writer.WriteLine(line);
                }
            }
        }

        private static void PrintTree(string node, int level, List<string> result)
        {
            result.Add(new string(' ', 2 * level) + node);

            if (tree.ContainsKey(node))
            {
                foreach (string child in tree[node].OrderBy(x => x))
                {
                    PrintTree(child, level + 1, result);
                }
            }
        }
    }
}