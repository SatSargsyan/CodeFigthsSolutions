//Given a string, check if it can become a palindrome through a case change of some(possibly, none) letters.

//Example

//For inputString = "AaBaa", the output should be
//isCaseInsensitivePalindrome(inputString) = true.

//"aabaa" is a palindrome as well as "AABAA", "aaBaa", etc.

//For inputString = "abac", the output should be
//isCaseInsensitivePalindrome(inputString) = false.

//All the strings which can be obtained via changing case of some group of letters, i.e. "abac", "Abac", "aBAc" and 13 more, are not palindromes.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_case_Insensitive_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static bool isCaseInsensitivePalindrome(string inputString)
        {
            for (int i = 0; i < inputString.Length / 2; i++)
            {
                char[] c = {
            inputString[i],
            inputString[inputString.Length - i - 1]
        };
                for (int j = 0; j < 2; j++)
                {
                    if (c[j] >= 'a' && c[j] <= 'z')
                    {
                        c[j] = (char)(c[j] - 'a' + 'A');
                    }
                }
                if (c[0] != c[1])
                {
                    return false;
                }
            }

            return true;
        }
    //    static bool isCaseInsensitivePalindrome(string inputString)
    //    inputString = inputString.ToLower();
    //return inputString.Reverse().SequenceEqual(inputString);
    //}
    }
}
