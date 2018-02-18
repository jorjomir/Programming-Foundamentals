using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Evolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, List<int>>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (input[0] == "wubbalubbadubdub") 
                {
                    break;
                }
                //Ако речника не съдържа ПОКЕМОНА
                if (!dict.ContainsKey(input[0]))
                {
                    dict.Add(input[0], new Dictionary<string, List<int>>());
                    dict[input[0]].Add(input[1], new List<int> { int.Parse(input[2])});
                }
                //Ако речника съдържа ПОКЕМОНА
                else if (dict.ContainsKey(input[0]))
                {
                    //Ако се ВЪВЕДЕ само ИМЕТО на ПОКЕМОНА
                    if (input.Count() == 1 && input[0] != "wubbalubbadubdub")
                    {
                        //Ако ИМЕТО го ИМА в РЕЧНИКА
                        if (dict.ContainsKey(input[0]))
                        {
                            foreach (var item in dict[input[0]])
                            {
                                Console.WriteLine($"# {item.Key}");
                                //ГРЕШКА НЕ ИЗВЕЖДА ПО РЕДА НА INPUT!!!!!!!!!!!!!
                                foreach (var n in dict[input[0]][item.Key])
                                {
                                    Console.WriteLine($"{item.Key} <-> {n}");
                                }
                            }
                        }
                    }
                    else
                    {
                        //Ако речника Съдържа ЕВОЛЮЦИЯТА на ПОКЕМОНА
                        if (dict[input[0]].ContainsKey(input[1]))
                        {
                            dict[input[0]][input[1]].Add(int.Parse(input[2]));
                        }
                        //Ако речника не съдържа ЕВОЛЮЦИЯТА на ПОКЕМОНА
                        else if (!dict[input[0]].ContainsKey(input[1]))
                        {
                            dict[input[0]].Add(input[1], new List<int> { int.Parse(input[2]) });
                        }
                    }
                    
                }
                //The pokemons must be printed by order of input. Each pokemon’s evolutions 
                //must be ordered by evolution index in descending order.


            }
            foreach (var pokemon in dict)
            {
                Console.WriteLine($"# {pokemon.Key}");
                foreach (var evolution in dict[pokemon.Key])
                {
                    foreach (var lists in dict[pokemon.Key][evolution.Key].OrderByDescending(x=>x))
                    {
                        evolution.Key.OrderByDescending(x=>lists);
                        Console.WriteLine($"{evolution.Key} <-> {lists}");
                    }
                }
            }
        }
    }
}
