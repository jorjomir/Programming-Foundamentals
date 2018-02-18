using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int seckey = int.Parse(Console.ReadLine());
            List<string> websites = new List<string>();
            decimal loss = 0;
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(' ').ToArray();
                websites.Add(data[0]);
                loss += decimal.Parse(data[1])* decimal.Parse(data[2]);

            }
            BigInteger biglost = new BigInteger(loss);
            BigInteger securitytoken = BigInteger.Pow(seckey, websites.Count);
            foreach (var item in websites)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total Loss: {loss:f20}");
            Console.WriteLine($"Security Token: { securitytoken}");

        }
    }
}
