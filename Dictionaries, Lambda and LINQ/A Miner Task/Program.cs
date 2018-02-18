using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, long>();
            string metal = Console.ReadLine();
            long value;
            while (metal!="stop")
            {
                value = long.Parse(Console.ReadLine());
                    if (dict.ContainsKey(metal))
                    {
                        dict[metal] += value;
                    }
                    else
                    {
                        dict.Add(metal, value);
                    }
                metal = Console.ReadLine();

            }
            foreach (var x in dict)
            {
                Console.WriteLine($"{x.Key} -> {x.Value}");
            }
        }
    }
}
