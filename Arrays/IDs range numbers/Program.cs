using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDs_range_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("От: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("До: ");
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();
        }
    }
}
