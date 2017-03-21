using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magical_well
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int n = 2;

            Console.WriteLine(magicalWell( a,  b,  n));

            Console.ReadKey();
        }
      static  int magicalWell(int a, int b, int n)
        {
            return Enumerable.Repeat(0, n).Sum(x => a++ * b++);
        }

    }
}
