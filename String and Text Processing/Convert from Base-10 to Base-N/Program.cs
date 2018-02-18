using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_from_Base_10_to_Base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            ulong Nbase = ulong.Parse(input[0]);
            ulong number = ulong.Parse(input[1]);
            ulong reminder;
            string result = string.Empty;
            while (number>0)
            {
                reminder = number % Nbase;
                number /= Nbase;
                result = reminder.ToString() + result;
            }
            Console.WriteLine(result);
        }
    }
}
