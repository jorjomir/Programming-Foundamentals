using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] arr2 = new int[arr.Length];
            for (int i = 0; i < n; i++)
            {
                Rotate(arr);
                for (int j = 0; j < arr.Length; j++)
                {
                    arr2[j] += arr[j];
                }
            }
            Console.WriteLine(String.Join(" ", arr2));
        }
        static void Rotate(int[] arr)
        {
            var lastElement = arr[arr.Length-1];
            for (int i = arr.Length-1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = lastElement;
        }
    }
}
