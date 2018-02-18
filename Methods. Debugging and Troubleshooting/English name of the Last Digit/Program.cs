using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_name_of_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            LastDigit(n);
        }
        static void LastDigit(long n)
        {
            long last = n % 10;
            if (last==0)
            {
                Console.WriteLine("zero");
            }
            else if (last==1)
            {
                Console.WriteLine("one");
            }
            else if (last==2)
            {
                Console.WriteLine("two");
            }
            else if (last==3)
            {
                Console.WriteLine("three");
            }
            else if (last==4)
            {
                Console.WriteLine("four");
            }
            else if (last==5)
            {
                Console.WriteLine("five");
            }
            else if (last==6)
            {
                Console.WriteLine("six");
            }
            else if (last==7)
            {
                Console.WriteLine("seven");
            }
            else if (last==8)
            {
                Console.WriteLine("eight");
            }
            else if(last==9)
            {
                Console.WriteLine("nine");
            }
        }
    }
}
