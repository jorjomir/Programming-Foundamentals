using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            List<int> dangerousPlaces = GetAllDangerousPlaces(numbers, bomb[0], bomb[1]);

            long sum = 0;

            for (int index = 0; index < numbers.Count; index++)
            {
                if (!dangerousPlaces.Contains(index))
                {
                    sum += numbers[index];
                }
            }

            Console.WriteLine(sum);
        }

        static List<int> GetAllDangerousPlaces(List<int> numbers, int bomb, int power)
        {
            List<int> allBombs = new List<int>();

            for (int index = 0; index < numbers.Count; index++)
            {
                if (numbers[index] == bomb)
                {
                    allBombs.Add(index);
                }
            }

            List<int> allDangerousPlaces = new List<int>();

            for (int i = 0; i < allBombs.Count; i++)
            {
                allDangerousPlaces.Add(allBombs[i]);

                for (int j = 1; j <= power; j++)
                {
                    allDangerousPlaces.Add(allBombs[i] - j);
                    allDangerousPlaces.Add(allBombs[i] + j);
                }
            }

            return allDangerousPlaces;
        }
    }
    }

