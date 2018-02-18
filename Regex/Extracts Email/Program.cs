using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Extracts_Email
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            foreach (Match item in Regex.Matches(text, @"\w+@\w+\.\w+"))
            {
                Console.WriteLine(item);
            }
        }
    }
}
