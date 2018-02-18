using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Exchangeable_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var read1 = ulong.Parse(Console.ReadLine());
            var read2 = ulong.Parse(Console.ReadLine());
            var line1 = new BigInteger(read1);
            var line2 = new BigInteger(read2);
            Console.WriteLine(line1+line2);


        }
    }
}
