using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_in_reversed_order
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            Reversed(n);
        }
        static void Reversed(double n)
        {
            string a = n.ToString();
            Console.WriteLine(string.Join("", a.Reverse())); ;
        }
    }
}
