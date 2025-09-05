// Escribe un programa que recorra e imprima los elementos de una matriz en forma de espiral.
using System;

class Programa
{
    static void Main()
    {
        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.WriteLine("Recorrido en espiral:");
        ImprimirEspiral(matriz);
    }

    static void ImprimirEspiral(int[,] matriz)
    {
        int filaInicio = 0;
        int filaFin = matriz.GetLength(0) - 1;
        int colInicio = 0;
        int colFin = matriz.GetLength(1) - 1;

        while (filaInicio <= filaFin && colInicio <= colFin)
        {
 
            for (int col = colInicio; col <= colFin; col++)
                Console.Write(matriz[filaInicio, col] + " ");
            filaInicio++;

            for (int fila = filaInicio; fila <= filaFin; fila++)
                Console.Write(matriz[fila, colFin] + " ");
            colFin--;

            if (filaInicio <= filaFin)
            {
                for (int col = colFin; col >= colInicio; col--)
                    Console.Write(matriz[filaFin, col] + " ");
                filaFin--;
            }

            if (colInicio <= colFin)
            {
                for (int fila = filaFin; fila >= filaInicio; fila--)
                    Console.Write(matriz[fila, colInicio] + " ");
                colInicio++;
            }
        }
    }
}

