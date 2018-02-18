using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_for_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var cmdnums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < cmdnums[1]; i++)
            {
                int j = 0;
                nums.RemoveAt(j);
                j++;
            }
            if (nums.Contains(cmdnums[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
