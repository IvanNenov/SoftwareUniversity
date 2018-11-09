using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DrawFilledSquare
{
    public class DrawFilledSquare
    {
        public static void Main(string[] args)
        {
            int howBig = int.Parse(Console.ReadLine());
            PrintSquare(howBig);
        }

        static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        static void PrintMiddleRow(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }

        static void PrintSquare(int n)
        {
            PrintHeaderRow(n);
            for (int i = 0; i < n - 2; i++)
            {
                PrintMiddleRow(n);
            }

            PrintHeaderRow(n);
        }
    }
}