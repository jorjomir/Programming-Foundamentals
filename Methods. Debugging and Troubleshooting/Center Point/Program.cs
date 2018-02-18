using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            Closest(x1, y1, x2, y2);
        }
        static void Closest(int x1, int y1, int x2, int y2)
        {
            int absx1 = Math.Abs(x1);
            int absx2 = Math.Abs(x2);
            int absy1 = Math.Abs(y1);
            int absy2 = Math.Abs(y2);
            if ((absx1+absy1)<(absy2+absx2))
            {
                    Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
