﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Extract_Sentences_by_keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            string[] sentences = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = "\\b" + word + "\\b";
            Regex rgx = new Regex(pattern);
            foreach (var sentence in sentences)
            {
                if (rgx.IsMatch(sentence))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
