using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                bool towa = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i%j==0)
                    {
                        towa = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {towa}");
            }
        }
    }
}
