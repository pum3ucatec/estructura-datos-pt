using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        List<int> espiral = RecorrerEspiral(matriz);

        Console.WriteLine("Recorrido en espiral: " + string.Join(", ", espiral));
    }

    static List<int> RecorrerEspiral(int[,] matriz)
    {
        List<int> resultado = new List<int>();

        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        int top = 0, bottom = filas - 1, left = 0, right = columnas - 1;

        while (top <= bottom && left <= right)
        {
            // 1. De izquierda a derecha
            for (int i = left; i <= right; i++)
                resultado.Add(matriz[top, i]);
            top++;

            // 2. De arriba a abajo
            for (int i = top; i <= bottom; i++)
                resultado.Add(matriz[i, right]);
            right--;

            // 3. De derecha a izquierda (si queda fila)
            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                    resultado.Add(matriz[bottom, i]);
                bottom--;
            }

            // 4. De abajo a arriba (si queda columna)
            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                    resultado.Add(matriz[i, left]);
                left++;
            }
        }

        return resultado;
    }
}
