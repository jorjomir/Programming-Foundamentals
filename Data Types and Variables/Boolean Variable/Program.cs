using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2 = "World";
            object obj = s1 + " " + s2;
            string s3 = (string)obj;
            Console.WriteLine(s3);
        }
    }
}
