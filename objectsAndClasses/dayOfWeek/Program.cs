using System;
using System.Globalization;

namespace dayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDate = Console.ReadLine();
            DateTime dayOfWeek = DateTime.ParseExact(inputDate, "d-M-yyyy", CultureInfo.InvariantCulture);
            var result = dayOfWeek.DayOfWeek;
            Console.WriteLine(result);
        }
    }
}
