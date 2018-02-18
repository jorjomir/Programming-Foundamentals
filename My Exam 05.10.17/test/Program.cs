using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string pattern = @"([a-zA-Z]+)(.+)(\1)";
            Regex rgx = new Regex(pattern);
            string[] placeholder = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string output;
            while (true)
            {
                if (true)
                {

                }
            }
        }
    }
}
