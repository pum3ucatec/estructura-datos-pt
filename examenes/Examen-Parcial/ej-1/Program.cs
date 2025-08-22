using System;
using System.Collections.Generic;

class Program
{
    static List<int> MatrizEnEspiral(int[,] matriz)
    {
        List<int> resultado = new List<int>();
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        int top = 0, bottom = filas - 1;
        int left = 0, right = columnas - 1;

        while (top <= bottom && left <= right)
        {
            // Este representa la Fila superior
            for (int i = left; i <= right; i++)
                resultado.Add(matriz[top, i]);
            top++;

            // Este representa la Columna derecha
            for (int i = top; i <= bottom; i++)
                resultado.Add(matriz[i, right]);
            right--;

            // Este representa la fila inferior
            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                    resultado.Add(matriz[bottom, i]);
                bottom--;
            }

            // Este representa la Columna izquierda
            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                    resultado.Add(matriz[i, left]);
                left++;
            }
        }

        return resultado;
    }

    static void Main()
    {
        int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        List<int> espiral = MatrizEnEspiral(matriz);

        Console.WriteLine("Matriz en espiral: " + string.Join(", ", espiral));
    }
}
