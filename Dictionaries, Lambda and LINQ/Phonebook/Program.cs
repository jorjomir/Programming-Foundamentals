using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();
            bool cancountinue = true;
            while (cancountinue)
            {
                string[] cmd = Console.ReadLine().Split(' ');
                if (cmd[0]=="A")
                {
                    if (dict.ContainsKey(cmd[1]))
                    {
                        dict[cmd[1]] = cmd[2];
                    }
                    else
                    {
                        dict.Add(cmd[1], cmd[2]);
                    }
                }
                if (cmd[0]=="S")
                {
                    if (dict.ContainsKey(cmd[1]))
                    {
                        Console.WriteLine($"{cmd[1]} -> {dict[cmd[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {cmd[1]} does not exist.");
                    }
                }
                if (cmd[0] == "END")
                {
                    cancountinue = false;
                }
            }
        }
    }
}
