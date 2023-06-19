namespace Task_2011
{
    internal class AgeAnalysis
    {
        public void GetAgeResult()
        {
            string[] lines = File.ReadAllLines("input.txt");
            int inputNumber = int.Parse(lines[0]);

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                if (inputNumber < 7 && inputNumber >= 0)
                {
                    writer.WriteLine("preschool child");
                } 
                else if (inputNumber <= 17)
                {
                    writer.WriteLine("schoolchild " + (inputNumber - 6));
                }
                else if (inputNumber <= 22)
                {
                    writer.WriteLine("student " + (inputNumber - 17));
                }
                else
                {
                    writer.WriteLine("specialist");
                }
            }
        }
    }
}