using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i = 0; i < n && i<20; i++)
            {
                string ingr = Console.ReadLine().ToLower();
                if (ingr=="cheese")
                {
                    total += 500;
                }
                else if (ingr=="tomato sauce")
                {
                    total += 150;
                }
                else if (ingr=="salami")
                {
                    total += 600;
                }
                else if (ingr=="pepper")
                {
                    total += 50;
                }
            }
            Console.WriteLine($"Total calories: {total}");
        }
    }
}
