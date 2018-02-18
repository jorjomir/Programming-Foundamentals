using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([a-zA-Z]+)(.+)(\1)";
            Regex rgx = new Regex(pattern);
            string[] placeholder = Console.ReadLine().Split(new char[] { '{', '}', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Match n = Regex.Match(input, pattern);
            for (int i = 0; i < Regex.Matches(input, pattern).Count; i++)
            {
                input = input.Replace(n.Groups[2].ToString(), $"{placeholder[i]}");
                n = n.NextMatch();
            }
            Console.WriteLine(input);
        }
    }
}
