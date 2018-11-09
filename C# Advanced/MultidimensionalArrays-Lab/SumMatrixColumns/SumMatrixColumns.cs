﻿using System;
using System.Linq;

class SumMatrixColumns
{
    static void Main()
    {
        int[] input = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int[,] matrix = new int[input[0], input[1]];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int[] colElements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = colElements[col];
            }
        }

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                sum += matrix[row, col];
            }

            Console.WriteLine(sum);
        }
    }
}