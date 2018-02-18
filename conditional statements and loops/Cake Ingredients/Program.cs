using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingr;
            for (int i = 0; i<=20 ; i++)
            {
                ingr = Console.ReadLine();
                if (ingr!="Bake!")
                {
                    Console.WriteLine($"Adding ingredient {ingr}.");
                }
                if (ingr=="Bake!")
                {
                    Console.WriteLine($"Preparing cake with {i} ingredients.");
                    break;
                }
            }
        }
    }
}
