using System;

namespace BooleanTostring
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            var converted = Convert.ToBoolean(command);
            if (converted)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
