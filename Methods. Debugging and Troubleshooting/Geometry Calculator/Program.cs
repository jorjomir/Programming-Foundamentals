using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            Calc(figure);
        }
        static void Calc(string figure)
        {
            if (figure=="triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double n = double.Parse(Console.ReadLine());
                Console.WriteLine($"{(a*n)/2:F2}");
            }
            else if (figure=="square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a*a:F2}");
            }
            else if (figure=="rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double n = double.Parse(Console.ReadLine());
                Console.WriteLine($"{(a * n):F2}");
            }
            else if (figure=="circle")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Math.PI*(a*a):F2}");
            }
        }

    }
}
