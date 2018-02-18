using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Working_Days2
{
    class Program
    {
        static void Main(string[] args)
        {
            string from = Console.ReadLine();
            string to = Console.ReadLine();
            DateTime datefrom = DateTime.ParseExact(from, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime dateto = DateTime.ParseExact(to, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            int workingdays = 0;
            for (DateTime i = datefrom; i <= dateto; i=i.AddDays(1))
            {
                
                if (i.DayOfWeek!=DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday && !(i.Month==1 && i.Day==1) && !(i.Month == 3 && i.Day == 3) && !(i.Month == 5 && i.Day == 1) && !(i.Month == 5 && i.Day == 6) && !(i.Month == 5 && i.Day == 24) && !(i.Month == 9 && i.Day == 6)
                    && !(i.Month == 9 && i.Day == 22) && !(i.Month == 11 && i.Day == 1) && !(i.Month == 12 && i.Day == 24) && !(i.Month == 12 && i.Day == 25) && !(i.Month == 12 && i.Day == 26))
                {
                    workingdays++;
                }
            }
            Console.WriteLine(workingdays);

        }
    }
}
