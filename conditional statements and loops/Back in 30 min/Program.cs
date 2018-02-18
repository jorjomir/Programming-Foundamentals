using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_in_30_min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            min += 30;
            if (min>60)
            {
                min -= 60;
                hour += 1;
                if (hour>23)
                {
                    hour -= 24;
                }
            }
            Console.WriteLine($"{hour}:{min}");
        }
    }
}
