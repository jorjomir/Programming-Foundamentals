using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a<b)
            {
                for (int i = a + 1; a <= b; a++)
                {
                    Console.WriteLine(a);
                }
            }
            else
            {
                for (int i = b + 1; b <= a; b++)
                {
                    Console.WriteLine(b);
                }
            }
            

        }
    }
}
