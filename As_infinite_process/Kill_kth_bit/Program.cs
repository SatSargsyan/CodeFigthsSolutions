
//In order to stop the Mad Coder evil genius you need to decipher the encrypted message he sent to his minions.The message contains several numbers that, when typed into a supercomputer, will launch a missile into the sky blocking out the sun, and making all the people on Earth grumpy and sad.

//You figured out that some numbers have a modified single digit in their binary representation.More specifically, in the given number n the kth bit from the right was initially set to 0, but its current value might be different.It's now up to you to write a function that will change the kth bit of n back to 0.

//Example

//For n = 37 and k = 3, the output should be
//killKthBit(n, k) = 33.

//3710 = 1001012 ~> 1000012 = 3310.

//For n = 37 and k = 4, the output should be
//killKthBit(n, k) = 37.

//The 4th bit is 0 already(looks like the Mad Coder forgot to encrypt this number), so the answer is still 37.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kill_kth_bit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 37;
            int k = 3;
            int k1 = 4;
            Console.WriteLine(killKthBit(n,k));
            Console.WriteLine(killKthBit(n, k1));

            Console.ReadLine();

        }
        static int killKthBit(int n, int k)
        {
            //            string s2=string.Empty;
            //string s1 = Convert.ToString(n, 2);

            //for (int i = 0; i <k; i++)
            //{
            //    s2 += s1[i];
            //}
            //if (s1[k] == 0)
            //    s2 = s2 + "1";
            //else s2 = s2 + "0";

            //for (int i = k+1; i < s1.Length; i++)
            //{
            //    s2 += s1[i];
            //}



            //return Convert.ToInt32(s2, 2); 
            //return (n & (int)Math.Pow(2, k - 1)) == 0 ? n : n - (int)Math.Pow(2, k - 1);
            return n & ~(1 << (k - 1));
        }
    }
}
