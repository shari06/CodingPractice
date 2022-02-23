using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Problems
{
    public class Longest_Palindrome
    {
        public string LongestPalindrome(string s)
        {
            string longest = string.Empty;
            if (string.IsNullOrEmpty(s))
            {
                return "";
            }

            for (int i = 0; i < s.Length; i++)
            {
                //Odd Palindrome
                //EvenPalindrome
                var oddPalindrome = ExpandFromCenter(s, i, i);
                var EvenPalindrome = ExpandFromCenter(s, i, i + 1);

                if (oddPalindrome.Length > longest.Length)
                {
                    longest = oddPalindrome;
                }

                if (EvenPalindrome.Length > longest.Length)
                {
                    longest = EvenPalindrome;
                }

            }
            return longest;
        }

        public string ExpandFromCenter(string str, int left, int right)
        {
            var strArr = str.ToCharArray();
            while (left >= 0 && (right < strArr.Length) && strArr[left] == strArr[right])
            {
                left--;
                right++;
            }
            return str.Substring(left + 1, right - left - 1);
        }
    }
}
