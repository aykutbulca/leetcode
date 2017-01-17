using System;

namespace LeetCode.Problems
{
    public class Question7
    {
        public int Reverse(int x) {
            string number = x.ToString();
            bool isNegativeNumber = number.IndexOf('-') >= 0;
            number = number.Replace('-', ' ').Trim();
            Char[] chars = number.ToCharArray();
            Array.Reverse(chars);
            string reversedNumber = (isNegativeNumber ? "-": "") + new string(chars).TrimStart('0');

            int reversed = 0;
            Int32.TryParse(reversedNumber, out reversed);

            return reversed;
        }
    }
}
