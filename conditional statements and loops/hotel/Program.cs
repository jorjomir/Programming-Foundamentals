using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            if (month == "May" || month == "October")
            {
                if (nights > 7 && month=="May")
                {
                    Console.WriteLine($"Studio: {(nights * 50) * 0.95:F2} lv.");
                }
                else if (nights < 7 && month == "May")
                {
                    Console.WriteLine($"Studio: {(nights * 50):F2} lv.");
                }
                else if (month=="October" && nights>7)
                {
                    Console.WriteLine($"Studio: {((nights * 50)-50) * 0.95:F2} lv.");
                }
                Console.WriteLine($"Double: {nights * 65:F2} lv.");
                Console.WriteLine($"Suite: {nights * 75:F2} lv.");
            }
            else if (month == "June" || month=="September")
            {
                if (month=="September" && nights>7)
                {
                    Console.WriteLine($"Studio: {((nights-1) * 60):F2} lv.");
                }
                else
                {
                    Console.WriteLine($"Studio: {(nights * 60):F2} lv.");
                }
                if (nights>14)
                {
                    Console.WriteLine($"Double: {(nights*72)*0.9:F2} lv.");
                }
                else
                {
                    Console.WriteLine($"Double: {(nights * 72):F2} lv.");
                }
                Console.WriteLine($"Suite: {nights*82:F2} lv.");
            }
            else if (month == "July" || month == "December" || month == "August")
            {
                Console.WriteLine($"Studio: {nights*68:F2} lv.");
                Console.WriteLine($"Double: {nights*77:F2} lv.");
                if (nights>14)
                {
                    Console.WriteLine($"Suite: {nights*89*0.85:F2} lv.");
                }
                else
                {
                    Console.WriteLine($"Suite: {nights*89:F2} lv.");
                }
            }
        }
    }
}
