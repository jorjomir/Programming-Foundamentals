using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            int ml = int.Parse(Console.ReadLine());
            int kcal = int.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());
            Console.WriteLine($"{ml}ml {name}:");
            Console.WriteLine($"{(ml*kcal)/100}kcal, {(ml*sugar)/100}g sugars");
        }
    }
}
