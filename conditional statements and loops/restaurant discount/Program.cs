using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pack = Console.ReadLine();
            double small = 2500;
            double terrace = 5000;
            double great = 7500;
            int normal = 500;
            int gold = 750;
            int platinum = 1000;
            if (n <= 50)
            {
                Console.WriteLine("We can offer you the Small Hall");
                if (pack == "Normal")
                {
                    small = (normal + small);
                    small -= small * 0.05;
                    Console.WriteLine($"The price per person is {(small / n):F2}$");
                }
                else if (pack == "Gold")
                {
                    small = (gold + small);
                    small -= small * 0.1;
                    Console.WriteLine($"The price per person is {(small / n):F2}$");
                }
                else if (pack == "Platinum")
                {
                    small = (platinum + small);
                    small -= small * 0.15;
                    Console.WriteLine($"The price per person is {(small / n):F2}$");
                }
            }
            else if (n > 50 && n <= 100)
            {
                Console.WriteLine("We can offer you the Terrace");
                if (pack == "Normal")
                {
                    terrace = (normal + terrace);
                    terrace -= terrace * 0.05;
                    Console.WriteLine($"The price per person is {(terrace / n):F2}$");
                }
                else if (pack == "Gold")
                {
                    terrace = (gold + terrace);
                    terrace -= terrace * 0.1;
                    Console.WriteLine($"The price per person is {(terrace / n):F2}$");
                }
                else if (pack == "Platinum")
                {
                    terrace = (platinum + terrace);
                    terrace -= terrace * 0.15;
                    Console.WriteLine($"The price per person is {(terrace / n):F2}$");
                }
            }
            else if (n > 100 && n<=120)
            {
                Console.WriteLine("We can offer you the Great Hall");
                if (pack == "Normal")
                {
                    great = (normal + great);
                    great -= great * 0.05;
                    Console.WriteLine($"The price per person is {(great / n):F2}$");
                }
                else if (pack == "Gold")
                {
                    great = (gold + great);
                    great -= great * 0.1;
                    Console.WriteLine($"The price per person is {(great / n):F2}$");
                }
                else if (pack == "Platinum")
                {
                    great = (platinum + great);
                    great -= great * 0.15;
                    Console.WriteLine($"The price per person is {(great / n):F2}$");
                }
            }
            else if (n>120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }

    }
}
