using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_method
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Max(a,b,c);
        }
        static void Max(int a, int b, int c)
        {
            int maxnum = Math.Max(a, b);
            Console.WriteLine(Math.Max(maxnum,c));
        }

        
    }
}
