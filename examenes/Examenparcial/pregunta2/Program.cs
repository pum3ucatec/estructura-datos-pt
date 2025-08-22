﻿using System;
using System.Collections.Generic;

class Program
{
    /// <summary>
    /// Recorre una matriz en forma de espiral y devuelve los elementos en una lista.
    /// </summary>
    /// <param name="matrix">Matriz de enteros</param>
    /// <returns>Lista con los elementos en orden espiral</returns>
    static List<int> SpiralOrder(int[,] matrix)
    {
        List<int> result = new List<int>();

        if (matrix == null || matrix.Length == 0)
            return result;

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int top = 0, bottom = rows - 1;
        int left = 0, right = cols - 1;

        while (top <= bottom && left <= right)
        {
            // Recorrer la fila superior de izquierda a derecha
            for (int col = left; col <= right; col++)
                result.Add(matrix[top, col]);
            top++;

            // Recorrer la columna derecha de arriba hacia abajo
            for (int row = top; row <= bottom; row++)
                result.Add(matrix[row, right]);
            right--;

            if (top <= bottom)
            {
                // Recorrer la fila inferior de derecha a izquierda
                for (int col = right; col >= left; col--)
                    result.Add(matrix[bottom, col]);
                bottom--;
            }

            if (left <= right)
            {
                // Recorrer la columna izquierda de abajo hacia arriba
                for (int row = bottom; row >= top; row--)
                    result.Add(matrix[row, left]);
                left++;
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        int[,] matriz = {
            { 1,  2,  3,  4,  5 },
            { 6,  7,  8,  9, 10 },
            { 11, 12, 13, 14, 15 },
            { 16, 17, 18, 19, 20 }
        };

        List<int> espiral = SpiralOrder(matriz);
        Console.WriteLine("Elementos en orden espiral:");
        Console.WriteLine(string.Join(", ", espiral));
    }
}