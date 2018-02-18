using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lady_Bugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[int.Parse(Console.ReadLine())];
            List<int> positions = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < positions.Count; i++)
            {
                if (positions[i]>=0 && positions[i]<arr.Length)
                {
                    arr[i] = 1;
                }
            }
            while (true)
            {
                string[] cmd = Console.ReadLine().Split(' ').ToArray();
                if (cmd[0]=="end")
                {
                    break;
                }
                int cellfrom=int.Parse(cmd[0]);
                string direction = cmd[1];
                int flyLength = int.Parse(cmd[2]);
                if (direction=="right")
                {
                    for (int i = 0; i <  ; i++)
                    {

                    }
                }
            }

        }
    }
}
