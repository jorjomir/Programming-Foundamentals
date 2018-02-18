using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int br = 1;
            int brmax = 1;
            int num = 0;
            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i]==nums[i-1])
                {
                    br++;
                    if (br>brmax)
                    {
                        brmax = br;
                        num = nums[i];
                    }
                }
                else
                {
                    br = 1;
                }
            }
            for (int i = 0; i < brmax; i++)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
