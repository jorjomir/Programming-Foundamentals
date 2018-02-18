using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            char s1 = char.Parse(Console.ReadLine());
            char s2 = char.Parse(Console.ReadLine());
            char s3 = char.Parse(Console.ReadLine());
            Console.WriteLine($"{s3}{s2}{s1}");
        }
    }
}
