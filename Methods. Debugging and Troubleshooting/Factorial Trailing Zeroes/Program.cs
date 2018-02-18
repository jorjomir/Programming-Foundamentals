using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger factorial = num;
            for ( int i = 1; i < num; i++)
            {
                factorial = factorial * i;
            }
            int zeroes = 0;
            do
            {
                factorial= factorial / 10;
                zeroes += 1;
            } while (factorial%10==0);
            Console.WriteLine(zeroes);
        }
    }
}
