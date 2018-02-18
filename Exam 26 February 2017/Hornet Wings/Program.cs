using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            double meters = (n / 1000) * m;
            int rests = n / p;
            int secs = (n / 100) + rests * 5;
            Console.WriteLine($"{meters:f2} m.");
            Console.WriteLine($"{secs} s.");
        }
    }
}
