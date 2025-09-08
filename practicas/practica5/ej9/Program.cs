using System;
using System.Collections.Generic;

class Program
{
    static List<int> SpiralOrder(int[,] matrix)
    {
        List<int> result = new List<int>();
        int top = 0, bottom = matrix.GetLength(0) - 1;
        int left = 0, right = matrix.GetLength(1) - 1;

        while (top <= bottom && left <= right)
        {
            for (int j = left; j <= right; j++) result.Add(matrix[top, j]);
            top++;

            for (int i = top; i <= bottom; i++) result.Add(matrix[i, right]);
            right--;

            if (top <= bottom)
            {
                for (int j = right; j >= left; j--) result.Add(matrix[bottom, j]);
                bottom--;
            }

            if (left <= right)
            {
                for (int i = bottom; i >= top; i--) result.Add(matrix[i, left]);
                left++;
            }
        }
        return result;
    }

    static void Main()
    {
        int[,] matrix = { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };
        Console.WriteLine("Espiral: " + string.Join(", ", SpiralOrder(matrix)));
    }
}
