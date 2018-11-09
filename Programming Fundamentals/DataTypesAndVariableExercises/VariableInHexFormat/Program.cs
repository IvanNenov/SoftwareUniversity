using System;

namespace VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexaDecimal = Console.ReadLine();

            var converted = Convert.ToInt32(hexaDecimal, 16);
            Console.WriteLine(converted);
        }
    }
}
