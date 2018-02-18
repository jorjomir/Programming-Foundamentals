using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new SortedDictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine().Trim();
            while (input!="end")
            {
                string[] s = input.Split(new char[] {'=' , ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string ip = s[1];
                string nickname = s[5];
                int cnt = 1;
                if (!dict.ContainsKey(nickname))
                {
                    dict.Add(nickname, new Dictionary<string, int>());
                }
                if (!dict[nickname].ContainsKey(ip))
                {
                    dict[nickname].Add(ip, cnt);
                }
                else
                {
                    dict[nickname][ip]++;
                }

                input = Console.ReadLine();
            }
            foreach (var user in dict)
            {
                Console.WriteLine($"{user.Key}: ");
                foreach (var log in user.Value)
                {
                    var thing = log.Key;
                    if (log.Key != user.Value.Keys.Last())
                    {
                        Console.Write($"{log.Key} => {log.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{log.Key} => {log.Value}.");
                    }
                }
            }
        }
    }
}
