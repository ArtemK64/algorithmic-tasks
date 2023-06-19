namespace Task_2014
{
    internal class EuclidsAlgorithm
    {
        public void GetGreatestCommonDivisor() 
        {
            string[] lines = File.ReadAllLines("input.txt");
            string[] numbers = lines[0].Split(" ");
            int firstNumber = int.Parse(numbers[0]);
            int secondNumber = int.Parse(numbers[1]);

            while (secondNumber != 0)
            {
                int temp = secondNumber;
                secondNumber = firstNumber % secondNumber;
                firstNumber = temp;
            }

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine(firstNumber);
            }
        }
    }
}