namespace Task_2041
{
    internal class Palindrome
    {
        public void IsConcatinationOfTwoPalindromes()
        {
            string[] lines = File.ReadAllLines("input.txt");
            string inputString = lines[0];

            using (StreamWriter writer = new StreamWriter("output.txt")) 
            {
                bool flag = false;
                for (int i = 0; i < inputString.Length; i++)
                {
                    if (IsPalindrome(inputString.Substring(0, i + 1)) && IsPalindrome(inputString.Substring(i + 1, inputString.Length - i - 1)))
                    {
                        flag = true;
                        writer.WriteLine("YES");
                        break;
                    }
                }

                if (!flag) 
                {
                    writer.WriteLine("NO");
                }
            }
        }

        private bool IsPalindrome(string inputString)
        {
            int left = 0;
            int right = inputString.Length - 1;

            while (left < right)
            {
                if (inputString[left] != inputString[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
    }
}