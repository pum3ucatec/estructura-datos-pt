using System;
using System.Collections.Generic;

class Pregunta2
{
    static void Main(string[] args)
    {
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        List<int> result = SpiralOrder(matrix);

        Console.WriteLine("Recorrido en espiral:");
        Console.WriteLine(string.Join(", ", result));
    }

    static List<int> SpiralOrder(int[,] matrix)
    {
        List<int> result = new List<int>();

        if (matrix == null || matrix.Length == 0)
            return result;

        int top = 0;
        int bottom = matrix.GetLength(0) - 1;
        int left = 0;
        int right = matrix.GetLength(1) - 1;

        while (top <= bottom && left <= right)
        {
            // Recorre de izquierda a derecha
            for (int i = left; i <= right; i++)
                result.Add(matrix[top, i]);
            top++;

            // Recorre de arriba hacia abajo
            for (int i = top; i <= bottom; i++)
                result.Add(matrix[i, right]);
            right--;

            // Recorre de derecha a izquierda (si queda fila)
            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                    result.Add(matrix[bottom, i]);
                bottom--;
            }

            // Recorre de abajo hacia arriba (si queda columna)
            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                    result.Add(matrix[i, left]);
                left++;
            }
        }

        return result;
    }
}
