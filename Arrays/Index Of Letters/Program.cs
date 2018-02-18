using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_Of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().ToCharArray();
            char[] alphabet= new char[26];
            char letter = 'a';
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = letter;
                letter++;
            }
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (alphabet[j]==input[i])
                    {
                        Console.WriteLine($"{input[i]} -> {j}");
                    }
                }
            }
        }
    }
}
