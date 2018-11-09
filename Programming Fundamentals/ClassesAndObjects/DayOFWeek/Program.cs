using System;
using System.Globalization;

namespace DayOFWeek
{
    class Program
    {

        static void Main(string[] args)
        {
            string date = Console.ReadLine();

            var datetime = DateTime.ParseExact(date, "d-M-yyyy", provider: CultureInfo.InvariantCulture);

            Console.WriteLine(datetime.DayOfWeek);
        }
    }
}
