using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string[] nameOfDays = new string[7];

            nameOfDays[0] = "Monday";
            nameOfDays[1] = "Tuesday";
            nameOfDays[2] = "Wednesday";
            nameOfDays[3] = "Thursday";
            nameOfDays[4] = "Friday";
            nameOfDays[5] = "Saturday";
            nameOfDays[6] = "Sunday";

            if (day > 7 || day < 1)
            {
                Console.WriteLine("Invalid Day!");
            }

            else
            {
                Console.WriteLine(nameOfDays[day-1]);
            }



        }
    }
}
