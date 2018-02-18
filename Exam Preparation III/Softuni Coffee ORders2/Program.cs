using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softuni_Coffee_ORders2
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfOrders = int.Parse(Console.ReadLine());
            decimal totalprice;
            int capsules;
            List<decimal> ceni = new List<decimal>();
            for (int i = 0; i < NumberOfOrders; i++)
            {
                decimal pricecapsule = decimal.Parse(Console.ReadLine());
                string date = Console.ReadLine();
                DateTime month = DateTime.ParseExact(date, "d/M/yyyy", CultureInfo.InvariantCulture);
                capsules = int.Parse(Console.ReadLine());
                int daysinmonth = DateTime.DaysInMonth(month.Year, month.Month);
                totalprice = daysinmonth * pricecapsule * capsules;
                ceni.Add(totalprice);
            }
            foreach (var item in ceni)
            {
                Console.WriteLine($"The price for the coffee is: ${item:f2}");
            }
            Console.WriteLine($"Total: ${ceni.Sum():f2}");
        }
    }
}
