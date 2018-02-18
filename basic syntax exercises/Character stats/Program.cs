using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_stats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int maxhealth = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int maxenergy = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}");
            Console.Write($"Health: |");
            for (int i = 0; i < health; i++)
            {
                Console.Write("|");
            }
            for (int n = 0; n < maxhealth-health; n++)
            {
                Console.Write(".");
            }
            Console.WriteLine("|");
            Console.Write("Energy: |");
            for (int j = 0; j < energy; j++)
            {
                Console.Write("|");
            }
            for (int m = 0; m < maxenergy-energy; m++)
            {
                Console.Write(".");
            }
            Console.WriteLine("|");
        }
    }
}
