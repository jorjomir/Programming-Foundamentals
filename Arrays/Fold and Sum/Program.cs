using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] uprow1 = new int[arr.Length / 4];
            int[] uprow2 = new int[arr.Length / 4];
            int[] sumArr = new int[(arr.Length / 2)];
            for (int i = 0; i < uprow1.Length; i++)
            {
                uprow1[i] = arr[i];
            }
            int j = 1;
            for (int i = arr.Length - 1; j <= uprow2.Length; i--)
            {
                uprow2[j - 1] = arr[i];
                j++;
            }
            //Console.WriteLine(String.Join(" ", uprow2));
            //Console.WriteLine(String.Join(" ", uprow1));
            Array.Reverse(uprow1);
            j = arr.Length / 4;
            int broiach = 1;
            for (int i = 0; i < sumArr.Length; i++)
            {
                if (i < sumArr.Length / 2)
                {
                    sumArr[i] = uprow1[i] + arr[j];
                    j++;
                }
                else
                {
                    sumArr[i] = uprow2[broiach - 1] + arr[j];
                    broiach++;
                    j++;
                }
            }
            for (int i = 0; i < sumArr.Length; i++)
            {
                Console.Write($"{sumArr[i]} ");
            }
        }
    }
}
