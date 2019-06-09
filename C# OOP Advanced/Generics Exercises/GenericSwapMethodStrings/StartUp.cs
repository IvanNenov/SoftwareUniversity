﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodStrings
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var boxes = new List<Box<string>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                boxes.Add(new Box<string>(input));
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