using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> nameandgrades = new List<string>();
            double averagegrades = 0;
            var dict = new SortedDictionary<string, double>();
            for (int i = 0; i < n; i++)
            {
                nameandgrades = Console.ReadLine().Split(' ').ToList();
                for (int j = 1; j <= nameandgrades.Count-1; j++)
                {
                    averagegrades += double.Parse(nameandgrades[j]);
                }
                averagegrades = Math.Round(averagegrades / (nameandgrades.Count - 1), 2);
                dict.Add(nameandgrades[0], averagegrades);
                averagegrades = 0;
            }
            dict.OrderBy(x => x.Key);
            foreach (var x in dict)
            {
                if (x.Value>=5)
                {
                    Console.WriteLine($"{x.Key} -> {x.Value}");
                }
                
            }
        }
    }
}
