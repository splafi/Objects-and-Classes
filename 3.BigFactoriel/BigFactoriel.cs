using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _3.BigFactoriel
{
    class BigFactoriel
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            BigInteger n = 1;
            for (int i = 2; i <= m; i++)
            {
                n *= i;
            }
            Console.WriteLine(n);
        }
    }
}
