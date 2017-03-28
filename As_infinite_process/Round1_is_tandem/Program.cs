//Determine whether the given string can be obtained by one concatenation of some string to itself.

//Example

//For inputString = "tandemtandem", the output should be
//isTandemRepeat(inputString) = true;
//For inputString = "qqq", the output should be
//isTandemRepeat(inputString) = false;
//For inputString = "2w2ww", the output should be
//isTandemRepeat(inputString) = false.
//Input/Output

//[time limit] 500ms(cpp)
//[input]
//string inputString

//Constraints:
//3 ≤ inputString.length ≤ 20.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Round1_is_tandem
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "tandemtandem";
            string s2 = "tandemt";
            string s3 = "qqq";
            Console.WriteLine(isTandemRepeat(s1));
            Console.WriteLine(isTandemRepeat(s2));
            Console.WriteLine(isTandemRepeat(s3));

            Console.ReadKey();
        }
        static bool isTandemRepeat(string inputString)
        {
            char a;
            char b;

            int len = inputString.Length;
            if (len % 2 !=0)
            {
                return false;
            }
            for (int i = 0; i <len/2; i++)
            {
                a = inputString[i];
                b = inputString[i + len / 2];
                if ( a!= b)
                {
                    return false;
                }
                }

            return true;
        }
        //static bool isTandemRepeat(string inputString)
        //{
        //    if (inputString.Length == 1 || inputString.Length % 2 == 1)
        //        return false;
        //    string subString = inputString.Substring(0, inputString.Length / 2);
        //    string temp2 = inputString.Replace(subString, "");
        //    if (String.IsNullOrEmpty(temp2))
        //        return true;
        //    return false;
        //}
    }
}
