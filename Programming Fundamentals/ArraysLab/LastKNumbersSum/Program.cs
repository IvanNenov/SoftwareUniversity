using System;

namespace LastKNumbersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] sequence = new int[n];

            sequence[0] = 1;
            for (int i = 1; i <= n; i++)
            {
                sequence[0] = 1;
                if (i >= k)
                {
                  
                }
            }

            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
