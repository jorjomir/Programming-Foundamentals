using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            foreach (Match m in Regex.Matches(input, @"([^0-9]+)(\d+)"))
            {
                var num = int.Parse(m.Groups[2].Value);
                string let = m.Groups[1].Value.ToUpper();
                for (int i = 0; i < num; i++)
                {
                    result.Append(let);
                }
            }
            var cnt = result.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {cnt}");
            Console.WriteLine(result);
        }
    }
}
