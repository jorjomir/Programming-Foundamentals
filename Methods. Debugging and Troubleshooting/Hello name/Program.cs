using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_name
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            Name(n);
        }
        static void Name(string n)
        {
            Console.WriteLine($"Hello, {n}!");
        }
    }
}
