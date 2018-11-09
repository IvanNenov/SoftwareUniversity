using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] upper = new int[arr.Length / 2];
            int[] lower = new int[arr.Length / 2];

            int k = arr.Length / 4;

            for (int i = 0; i < 2 * k; i++)
            {
                lower[i] = arr[k + i];
            }
            for (int i = 0; i < k; i++)
            {
                upper[i] = arr[k - 1 - i];
                upper[k + i] = arr[4 * k - i - 1];

            }
            int[] sum = new int[2 * k];
            for (int i = 0; i < 2 * k; i++)
            {
                sum[i] = upper[i] + lower[i];
            }

            Console.WriteLine(string.Join(" ", sum));



        }
    }
}
