namespace Task_2048
{
    internal class Node
    {
        public string Name { get; set; }
        public List<Node> Child { get; set; }

        public Node(string name)
        {
            Name = name;
            Child = new List<Node>();
        }
    }
}