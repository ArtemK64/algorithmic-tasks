namespace Task_2032
{
    internal class CompareLongNumbers
    {
        public void CompareTwoArrays()
        {
            string[] lines = File.ReadAllLines("input.txt");
            int firstNumber = int.Parse(lines[1].Replace(" ", ""));
            int secondNumber = int.Parse(lines[3].Replace(" ", ""));

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                if (firstNumber < secondNumber)
                {
                    writer.WriteLine(-1);
                } 
                else if (secondNumber > firstNumber) 
                {
                    writer.WriteLine(1);
                }
                else
                {
                    writer.WriteLine(0);
                }
            }
        }
    }
}