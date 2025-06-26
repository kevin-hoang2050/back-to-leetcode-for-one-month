using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlay.ValidPlindrome
{
    internal class PalindromeSolution
    {
        static bool IsPalindrome(string s)
        {
            int left = 0, right = s.Length - 1;

            while (left < right)
            {
                while (left < right && !Char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }

                while (left < right && !Char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }

                if (Char.ToLower(s[left]) != Char.ToLower(s[right]))
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }

        public static void Main()
        {
            string[] testCases = {
            "A man, a plan, a canal: Panama",
            "race a car",
            "1A@2!3 23!2@a1",
            "No 'x' in Nixon",
            "radar"
        };

            foreach (string test in testCases)
            {
                Console.WriteLine($"\n\tString: {test}");
                bool result = IsPalindrome(test);
                Console.WriteLine($"\n\tResult: {result}");
                Console.WriteLine(new string('-', 150));
            }
        }
    }
}
