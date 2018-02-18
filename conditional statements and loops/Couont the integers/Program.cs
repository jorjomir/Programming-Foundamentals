using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couont_the_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInt = 0;
            try
            {
                while (true)
                {
                    var input = int.Parse(Console.ReadLine());
                    numberInt++;
                }

            }
            catch (Exception)
            {
                Console.WriteLine(numberInt);
            }
        }
    }
}
