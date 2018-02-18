using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte cent = byte.Parse(Console.ReadLine());
            ulong year = (ulong)(cent * 100);
            ulong days = (ulong)(year * 365.2422);
            ulong hours = 24 * days;
            ulong minutes = 60 * hours;
            ulong seconds = 60 * (ulong)minutes;
            decimal milliseconds = seconds * 1000;
            decimal microseconds = milliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;

            Console.WriteLine($"{cent} centuries = {year} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}