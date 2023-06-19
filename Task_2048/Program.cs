using System.Diagnostics;

namespace Task_2048
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string[] lines = File.ReadAllLines("input.txt");
            int qtyOfLines = int.Parse(lines[0]);
            Node root = new Node("");

            for (int i = 1; i <= qtyOfLines; i++)
            {
                Add(root, lines[i]);
            }

            List<string> resultTree = new List<string>();
            PrintTree(root, resultTree);
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                foreach (string item in resultTree)
                {
                    writer.WriteLine(item);
                }
            }

            stopwatch.Stop();
            Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }

        private static void Add(Node root, string path)
        {
            string[] components = path.Split('/');
            Node current = root;

            foreach (string component in components)
            {
                Node child = current.Child.Find(node => node.Name == component);

                if (child == null)
                {
                    child = new Node(component);
                    current.Child.Add(child);
                }

                current = child;
            }
        }

        private static void PrintTree(Node node, List<string> result, string indent = "")
        {
            string current = indent + node.Name;

            if (current.Length > 0)
            {
                result.Add(current);
            }
            
            List<Node> childrenSorted = node.Child;
            childrenSorted.Sort((firstNode, secondNode) => string.Compare(firstNode.Name, secondNode.Name));

            foreach (Node child in childrenSorted)
            {
                PrintTree(child, result, indent + "+");
            }
        }
    }
}