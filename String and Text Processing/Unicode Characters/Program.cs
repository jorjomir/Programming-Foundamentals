﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            foreach (var chr in input)
            {
                Console.Write("\\u{0:x4}", (int)chr);
            }
            Console.WriteLine();
        }
    }
}
