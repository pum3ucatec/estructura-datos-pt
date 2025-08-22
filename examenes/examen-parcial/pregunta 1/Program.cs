using System;
using System.Collections.Generic;

public class SpiralMatrix
{
    public static List<int> Traverse(int[,] matrix)
    {
        var result = new List<int>();

        if (matrix.GetLength(0) == 0)
        {
            return result;
        }

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int top = 0, bottom = rows - 1;
        int left = 0, right = cols - 1;

        while (top <= bottom && left <= right)
        {
            // Recorrer de izquierda a derecha
            for (int i = left; i <= right; i++)
            {
                result.Add(matrix[top, i]);
            }
            top++;

            // Recorrer de arriba a abajo
            for (int i = top; i <= bottom; i++)
            {
                result.Add(matrix[i, right]);
            }
            right--;

            // Recorrer de derecha a izquierda
            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                {
                    result.Add(matrix[bottom, i]);
                }
                bottom--;
            }

            // Recorrer de abajo a arriba
            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                {
                    result.Add(matrix[i, left]);
                }
                left++;
            }
        }

        return result;
    }

    public static void Main(string[] args)
    {
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        List<int> spiralOrder = Traverse(matrix);

        Console.WriteLine("Recorrido en espiral: " + string.Join(", ", spiralOrder));
    }
}