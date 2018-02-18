using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int sec = int.Parse(Console.ReadLine());

            decimal distanceInMiles = distance / 1609m;
            int totalSeconds = hours * 3600 + min * 60 + sec;

            float mps = (float)distance / totalSeconds;
            float kph = ((float)distance / 1000) / ((float)totalSeconds/3600);
            float mph = (float)distanceInMiles / ((float)totalSeconds/3600);
            Console.WriteLine(mps);
            Console.WriteLine(kph);
            Console.WriteLine(mph);
        }
    }
}
