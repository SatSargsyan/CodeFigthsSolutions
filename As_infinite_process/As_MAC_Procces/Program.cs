using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As_MAC_Procces
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static bool isMAC48Address(string inputString)
        {
            for (int i = 0; i < inputString.Length; i++)
            {
                if (i % 3 == 2)
                {
                    if (inputString[i] != '-')
                    {
                        return false;
                    }
                }
                else
                {
                    char sym = inputString[i];
                    if (!('0' <= sym && sym <= '9' || 'A' <= sym && sym <= 'F'))
                    {
                        return false;
                    }
                }
            }

            return inputString.Length == 17;
        }
    }
}
