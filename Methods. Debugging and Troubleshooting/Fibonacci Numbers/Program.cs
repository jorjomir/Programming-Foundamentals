using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Numbers
{
    class Program
    {
        public static void Fibonacci(int n)
        {
            if (n==0)
            {
                Console.WriteLine(1);
            }
            else if (n==)
            {

            }
            int Fib = (n - 1) + (n - 2);
            Console.WriteLine(Fib);

        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Fibonacci(n);
        }
    }
}


