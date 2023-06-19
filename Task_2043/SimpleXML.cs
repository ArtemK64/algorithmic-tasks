namespace Task_2043
{
    internal class SimpleXML
    {
        public void RectreateXMLHierarchy()
        {
            string[] lines = File.ReadAllLines("input.txt");
            string inputString = lines[0];
            Stack<char> stack = new Stack<char>();
            int level = 0;

            using (StreamWriter writer = new StreamWriter("output.txt")) 
            {
                for (int i = 0; i < inputString.Length; i++)
                {
                    if (inputString[i] == '<')
                    {
                        if (i + 1 < inputString.Length && inputString[i + 1] != '/')
                        {
                            stack.Push(inputString[i + 1]);
                            writer.WriteLine(new string(' ', level * 2) + "<" + inputString[i + 1] + ">");
                            level++;
                        }
                        else
                        {
                            level--;
                            writer.WriteLine(new string(' ', level * 2) + "</" + stack.Pop() + ">");
                            i++;
                        }
                    }
                }
            }
        }
    }
}