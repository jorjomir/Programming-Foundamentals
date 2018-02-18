using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            char[] arr1 = input[0].ToCharArray();
            char[] arr2 = input[1].ToCharArray();
            int totalsum=0;
            if (arr1.Length==arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    totalsum += arr1[i] * arr2[i];
                }
            }
            else if (arr1.Length>arr2.Length)
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    totalsum += arr1[i] * arr2[i];
                }
                for (int j = arr2.Length; j <arr1.Length ; j++)
                {
                    totalsum += arr1[j];
                }
            }
            else if (arr2.Length>arr1.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    totalsum += arr1[i] * arr2[i];
                }
                for (int j = arr1.Length; j < arr2.Length; j++)
                {
                    totalsum += arr2[j];
                }
            }
            Console.WriteLine(totalsum);
        }
    }
}
