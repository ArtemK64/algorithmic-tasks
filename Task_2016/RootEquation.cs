namespace Task_2016
{
    internal class RootEquation
    {
        public void getQtyOfRoots()
        {
            string[] lines = File.ReadAllLines("input.txt");
            string[] args = lines[0].Split(" ");
            
            int firstArg = int.Parse(args[0]);
            int secondArg = int.Parse(args[1]);
            int thirdArg = int.Parse(args[2]);

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                if (firstArg == 0)
                {
                    if (secondArg == 0)
                    {
                        writer.WriteLine("-1");
                    }
                    else
                    {
                        writer.WriteLine("1");
                    }
                }
                else
                {
                    double discriminant = Math.Pow(secondArg, 2) - 4 * firstArg * thirdArg;

                    if (discriminant > 0)
                    {
                        writer.WriteLine("2");
                    }
                    else if (discriminant == 0)
                    {
                        writer.WriteLine("1");
                    }
                    else
                    {
                        Console.WriteLine("0");
                    }
                }
            }
        }
    }
}