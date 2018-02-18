using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            name.Reverse().ToString();
            Console.WriteLine(ReverseString(name));
        }
        public static string ReverseString(string name)
        {
            char[] arr = name.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
