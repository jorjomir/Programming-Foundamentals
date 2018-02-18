using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            int x4 = int.Parse(Console.ReadLine());
            int y4 = int.Parse(Console.ReadLine());
            Longest(x1, y1, x2, y2, x3, y3, x4, y4);
        }
        static void Longest(int x1, int y1, int x2, int y2,int x3, int y3, int x4, int y4)
        {
            int absx1 = Math.Abs(x1);
            int absy1 = Math.Abs(y1);
            int absx2 = Math.Abs(x2);
            int absy2 = Math.Abs(y2);
            int absx3 = Math.Abs(x3);
            int absy3 = Math.Abs(y3);
            int absx4 = Math.Abs(x4);
            int absy4 = Math.Abs(y4);
            if ((absx1+absy1+absx2+absy2)>(absx3+absy3+absx4+absy4))
            {
                if ((absx1 + absy1) < (absy2 + absx2))
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if ((absx3 + absy3) < (absy4 + absx4))
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }
    }
}
