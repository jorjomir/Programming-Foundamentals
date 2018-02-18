using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hornet_comm
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictbroadcast = new Dictionary<string, List<string>>();
            var dictprivate = new Dictionary<string, List<string>>();

            StringBuilder frequency = new StringBuilder();
            while (true)
            {
                string message = Console.ReadLine();
                if (message=="Hornet is Green")
                {
                    break;
                }
                string patternprivate = @"([0-9]+) <-> (...+)";
                string patternbroadcast = @"([^0-9]+) <-> (...+)";
                //broadcast
                if (Regex.IsMatch(message, patternbroadcast))
                {
                    foreach (Match m in Regex.Matches(message,patternbroadcast))
                    {
                        string s = m.Groups[2].ToString();
                        for (int i = 0; i < s.Length; i++)
                        {
                            if (s[i]>96 && s[i]<123)
                            {
                                frequency.Append(Char.ToUpper(s[i]));
                            }
                            else if (s[i] > 64 && s[i] < 91)
                            {
                                frequency.Append(Char.ToLower(s[i]));
                            }
                            else
                            {
                                frequency.Append(s[i]);
                            }
                        }
                        if (!dictbroadcast.ContainsKey(frequency.ToString()))
                        {
                            dictbroadcast.Add(frequency.ToString(), new List<string> { m.Groups[1].ToString() });
                        }
                        else
                        {
                            dictbroadcast[frequency.ToString()].Add(m.Groups[1].ToString());
                        }
                        frequency.Clear();
                    }
                    //.ToString(), list.Add(m.Groups[1].ToString()));
                }
                //Private Message
                else if (Regex.IsMatch(message, patternprivate))
                {
                    foreach (Match m in Regex.Matches(message, patternprivate))
                    {
                        string recipents = m.Groups[1].ToString();
                        recipents = ReverseString(recipents);
                        if (!dictprivate.ContainsKey(recipents.ToString()))
                        {
                            dictprivate.Add(recipents.ToString(), new List<string> { m.Groups[2].ToString() });
                        }
                        else
                        {
                            dictprivate[recipents.ToString()].Add(m.Groups[2].ToString());
                        }
                    }
                }
            }
            Console.WriteLine("Broadcasts:");
            if (dictbroadcast.Count()==0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in dictbroadcast)
                {
                    foreach (var message in dictbroadcast[item.Key])
                    {
                        Console.WriteLine($"{item.Key} -> {message}");
                    }
                }
            }
            Console.WriteLine("Messages:");
            if (dictbroadcast.Count() == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in dictprivate)
                {
                    foreach (var message in dictprivate[item.Key])
                    {
                        Console.WriteLine($"{item.Key} -> {message}");
                    }
                }
            }
            

        }
        public static string ReverseString(string recipents)
        {
            char[] arr = recipents.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
