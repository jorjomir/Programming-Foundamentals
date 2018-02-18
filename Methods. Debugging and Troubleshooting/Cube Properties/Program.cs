using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string method = Console.ReadLine();
            Result(a,method);
        }
        static void Result(int a, string method)
        {
            if (method=="face")
            {
                double face = Math.Sqrt((2 * a * a));
                Console.WriteLine($"{face:F2}");
            }
            else if (method=="space")
            {
                double space = Math.Sqrt(3 * a * a);
                Console.WriteLine($"{space:F2}");
            }
            else if (method=="volume")
            {
                double volume = a * a * a;
                Console.WriteLine($"{volume:F2}");
            }
            else if (method=="area")
            {
                double area = 6 * a * a;
                Console.WriteLine($"{area:F2}");
            }
        }
    }
}
