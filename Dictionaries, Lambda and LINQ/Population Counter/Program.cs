using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new SortedDictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();
            while (input!="report")
            {
                string[] cmd = input.Split('|');
                string country = cmd[1];
                string city = cmd[0];
                int population = int.Parse(cmd[2]);
                if (!dict.ContainsKey(country))
                {
                    dict.Add(country, new Dictionary<string, long>());
                }
                if (!dict[country].ContainsKey(city))
                {
                    dict[country].Add(city, population);
                }

                input = Console.ReadLine();
            }
            foreach (KeyValuePair<string, Dictionary<string, long>> item in dict.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                long total = item.Value.Select(a => a.Value).ToList().Sum();
                Console.WriteLine($"{item.Key} (total population: {total})");
                foreach (var city in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
