using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Amanda";
            string sur = "Jonson";
            sbyte age = 27;
            char gender = 'f';
            long id = 8306112507;
            int num = 27563571;
            Console.WriteLine($"First name: {name}");
            Console.WriteLine($"Last name: {sur}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {id}");
            Console.WriteLine($"Unique Employee number: {num}");
        }
    }
}
