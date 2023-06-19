using System.Text;

namespace Task_2044
{
    internal class HuffmanAlgorithm
    {
        public void DecodeText()
        {
            string[] lines = File.ReadAllLines("input.txt");
            int qtyOfNumbers = int.Parse(lines[0]);
            Dictionary<string, char> codes = new Dictionary<string, char>();

            for (int i = 0; i < qtyOfNumbers; i++)
            {
                string[] line = lines[i + 1].Split(' ');
                char c = line[0][0];
                string code = line[1];
                codes[code] = c;
            }

            string encodedText = lines[qtyOfNumbers + 1];
            StringBuilder decodedText = new StringBuilder();
            
            using (StreamWriter writer = new StreamWriter("output.txt")) 
            {
                for (int i = 0; i < encodedText.Length;)
                {
                    foreach (var kvp in codes)
                    {
                        if (encodedText.StartsWith(kvp.Key))
                        {
                            decodedText.Append(kvp.Value);
                            encodedText = encodedText.Substring(kvp.Key.Length);
                            break;
                        }
                    }
                }
                writer.WriteLine(decodedText);
            }
        }
    }
}