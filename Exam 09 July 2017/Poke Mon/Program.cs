using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int noriginal = n;
            int count = 0;
            while (n>m)
            {
                if (n==noriginal/2)
                {
                    n = n / y;
                }
                n = n - m;
                count++;

            }
            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}
