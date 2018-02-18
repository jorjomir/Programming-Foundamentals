using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patternDidimon = @"([^a-zA-Z-]+)";
            string patternBojomon = @"([a-zA-Z]+-[a-zA-Z]+)";
            List<string> didimon = new List<string>();
            List<string> bojomon = new List<string>();
            foreach (Match item in Regex.Matches(input, patternDidimon))
            {
                didimon.Add(item.Groups[1].Value);
            }
            foreach (Match item in Regex.Matches(input, patternBojomon))
            {
                bojomon.Add(item.Groups[1].Value);
            }
            for (int i = 0; i < Math.Min(didimon.Count, bojomon.Count); i++)
            {
                Console.WriteLine(didimon[i]);
                Console.WriteLine(bojomon[i]);
            }
            if (didimon.Count>bojomon.Count)
            {
                for (int i = bojomon.Count-1; i < didimon.Count; i++)
                {
                    Console.WriteLine(didimon[i]);
                }
            }
            else
            {
                for (int i = didimon.Count - 1; i < bojomon.Count; i++)
                {
                    Console.WriteLine(bojomon[i]);
                }
            }
        }
    }
}
