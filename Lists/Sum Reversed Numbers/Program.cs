using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                int rev = 0;
                while (nums[i] > 0)
                {
                    int r = nums[i] % 10;
                    rev = rev * 10 + r;
                    nums[i] = nums[i] / 10;
                }
                sum += rev;
            }
            Console.WriteLine(sum);
        }
    }
}
