using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_don_t_go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int removed = 0;

            while (true)
            {
                int cmdindex = int.Parse(Console.ReadLine());
                if (cmdindex >= 0 && cmdindex < pokemons.Count)
                {
                    int cmdvalue = pokemons[cmdindex];
                    pokemons.RemoveAt(cmdindex);
                    removed += cmdvalue;
                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (cmdvalue >= pokemons[i])
                        {
                            pokemons[i] += cmdvalue;
                        }
                        else if (cmdvalue < pokemons[i])
                        {
                            pokemons[i] -= cmdvalue;
                        }
                    }
                }
                else
                {
                    if (cmdindex < 0)
                    {
                        pokemons[0] = pokemons[pokemons.Count - 1];
                    }
                    else if (cmdindex >= pokemons.Count)
                    {
                        pokemons[pokemons.Count - 1] = pokemons[0];
                    }
                }

                if (pokemons.Count == 0)
                {
                    break;
                }
            }
            Console.WriteLine(removed);
        }
    }
}
