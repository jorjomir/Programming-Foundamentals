using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string line = Console.ReadLine();

            while (!(line.Equals("Odd") || line.Equals("Even")))
            {
                var tokens = line.Split(' ');
                var command = tokens[0];
                if (command=="Delete")
                {
                    var num = int.Parse(tokens[1]);
                    nums.RemoveAll(x => x.Equals(num));
                }
                if(command=="Insert")
                {
                    var num1 = int.Parse(tokens[1]);
                    var num2 = int.Parse(tokens[2]);
                    nums.Insert(num2, num1);
                }
                line = Console.ReadLine();
            } 
            if (line == "Even")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i]%2==0)
                    {
                        Console.Write($"{nums[i]} ");
                    }
                }
            }
            if (line == "Odd")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] % 2 !=0)
                    {
                        Console.Write($"{nums[i]} ");
                    }
                }
            }
        }
    }
}
