using System;
using System.Collections.Generic;

class Program
{
    static List<int> RecorrerEspiral(int[,] matriz)
    {
        List<int> resultado = new List<int>();

        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        int inicioFila = 0, finFila = filas - 1;
        int inicioCol = 0, finCol = columnas - 1;

        while (inicioFila <= finFila && inicioCol <= finCol)
        {
            // Recorrer la fila superior de izquierda a derecha
            for (int col = inicioCol; col <= finCol; col++)
            {
                resultado.Add(matriz[inicioFila, col]);
            }
            inicioFila++;

            // Recorrer la columna derecha de arriba a abajo
            for (int fila = inicioFila; fila <= finFila; fila++)
            {
                resultado.Add(matriz[fila, finCol]);
            }
            finCol--;

            if (inicioFila <= finFila)
            {
                // Recorrer la fila inferior de derecha a izquierda
                for (int col = finCol; col >= inicioCol; col--)
                {
                    resultado.Add(matriz[finFila, col]);
                }
                finFila--;
            }

            if (inicioCol <= finCol)
            {
                // Recorrer la columna izquierda de abajo a arriba
                for (int fila = finFila; fila >= inicioFila; fila--)
                {
                    resultado.Add(matriz[fila, inicioCol]);
                }
                inicioCol++;
            }
        }

        return resultado;
    }

    static void Main()
    {
        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        List<int> espiral = RecorrerEspiral(matriz);

        Console.WriteLine("Elementos en espiral:");
        Console.WriteLine(string.Join(", ", espiral));
    }
}

