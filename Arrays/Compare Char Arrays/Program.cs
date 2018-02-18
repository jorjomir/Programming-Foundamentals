using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split().Select(char.Parse).ToArray();

            var minLength = Math.Min(arr1.Length, arr2.Length);
            bool isFirst = false;

            for (int i = 0; i < minLength; i++)
            {
                var index1 = (int)arr1[i];
                var index2 = (int)arr2[i];

                if (index1 <= index2)
                {
                    isFirst = true;
                }
                else
                {
                    break;
                }


            }

            if (isFirst == true && minLength == arr1.Length)
            {
                Console.WriteLine(string.Join("", arr1));
                Console.WriteLine(string.Join("", arr2));
            }
            else
            {
                Console.WriteLine(string.Join("", arr2));
                Console.WriteLine(string.Join("", arr1));
            }
        }
    }
}
