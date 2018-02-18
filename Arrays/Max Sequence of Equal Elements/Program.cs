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
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int br = 1;
            int brmax = 1;
            int num = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i]==arr[i+1])
                {
                    br++;
                    if (brmax < br)
                    {
                        brmax = br;
                        num = arr[i];

                    }
                }
                else
                {
                    br = 1;
                }
            }
            for (int j = 0; j < brmax; j++)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
