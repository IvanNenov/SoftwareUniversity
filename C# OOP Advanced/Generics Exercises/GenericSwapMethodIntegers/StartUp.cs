using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodIntegers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var boxes = new List<Box<int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = int.Parse(Console.ReadLine());

                boxes.Add(new Box<int>(input));
            }

            var indexes = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            var firstIndex = indexes[0];
            var secoundIndex = indexes[1];

            Swap(firstIndex, secoundIndex, boxes);

            foreach (var box in boxes)
            {
                Console.WriteLine(box);
            }
        }

        private static void Swap<T>(int firstIndex, int secoundIndex, List<Box<T>> boxes)
        {
            var temp = boxes[firstIndex];
            boxes[firstIndex] = boxes[secoundIndex];
            boxes[secoundIndex] = temp;
        }
    }
}
