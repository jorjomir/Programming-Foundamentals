using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_a_drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string prof = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            if (prof=="Athlete")
            {
                Console.WriteLine($"The {prof} has to pay {(n) * 0.7:F2}.");
            }
            else if(prof=="Businessman")
            {
                Console.WriteLine($"The {prof} has to pay {(n) * 1:F2}.");
            }
            else if (prof=="Businesswoman")
            {
                Console.WriteLine($"The {prof} has to pay {(n) * 1:F2}.");
            }
            else if (prof=="SoftUni Student")
            {
                Console.WriteLine($"The {prof} has to pay {(n) * 1.7:F2}.");
            }
            else
            {
                Console.WriteLine($"The {prof} has to pay {(n) * 1.2:F2}.");
            }
        }
    }
}
