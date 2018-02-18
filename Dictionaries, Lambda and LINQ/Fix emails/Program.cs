using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix_emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();
            string name = Console.ReadLine();
            string email;
            while (name!="stop")
            {
                email = Console.ReadLine();
                dict.Add(name, email);
                if (email.EndsWith("us") || email.EndsWith("uk"))
                {
                    dict.Remove(name);
                }
                name = Console.ReadLine();
            }
            foreach (var x in dict)
            {
                Console.WriteLine($"{x.Key} -> {x.Value}");
            }
        }
    }
}
