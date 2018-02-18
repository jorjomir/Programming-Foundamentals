using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            Random rnd = new Random();
            string p = phrases[rnd.Next(phrases.Count())];
            string e = phrases[rnd.Next(phrases.Count())];
            string a = phrases[rnd.Next(phrases.Count())];
            string c = phrases[rnd.Next(phrases.Count())];
            int n = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{p} {e} {a} {c}");
            for (int i = 0; i < n; i++)
            {
                
                Console.Write($"{p} {e} {a} - {c}");
                Console.WriteLine();
            }
        }
    }
}
