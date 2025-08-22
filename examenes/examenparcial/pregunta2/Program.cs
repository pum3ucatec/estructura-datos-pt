using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Tres matrices de ejemplo diferentes
        int[,] matriz1 = {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12}
        };

        int[,] matriz2 = {
            {10, 20, 30},
            {40, 50, 60},
            {70, 80, 90},
            {100, 110, 120}
        };

        int[,] matriz3 = {
            {15, 25, 35, 45, 55},
            {65, 75, 85, 95, 105}
        };

        Console.WriteLine("=== RECORRIDO EN ESPIRAL DE MATRICES ===\n");

        Console.WriteLine("Matriz 1 (3x4):");
        ImprimirMatriz(matriz1);
        Console.WriteLine("Espiral: " + string.Join(", ", RecorrerEnEspiral(matriz1)) + "\n");

        Console.WriteLine("Matriz 2 (4x3):");
        ImprimirMatriz(matriz2);
        Console.WriteLine("Espiral: " + string.Join(", ", RecorrerEnEspiral(matriz2)) + "\n");

        Console.WriteLine("Matriz 3 (2x5):");
        ImprimirMatriz(matriz3);
        Console.WriteLine("Espiral: " + string.Join(", ", RecorrerEnEspiral(matriz3)) + "\n");
    }

    public static List<int> RecorrerEnEspiral(int[,] matriz)
    {
        List<int> resultado = new List<int>();
        
        if (matriz == null || matriz.Length == 0)
            return resultado;

        int filaInicio = 0;
        int filaFin = matriz.GetLength(0) - 1;
        int columnaInicio = 0;
        int columnaFin = matriz.GetLength(1) - 1;

        while (filaInicio <= filaFin && columnaInicio <= columnaFin)
        {
            // Recorrer de izquierda a derecha (fila superior)
            for (int j = columnaInicio; j <= columnaFin; j++)
            {
                resultado.Add(matriz[filaInicio, j]);
            }
            filaInicio++;

            // Recorrer de arriba a abajo (columna derecha)
            for (int i = filaInicio; i <= filaFin; i++)
            {
                resultado.Add(matriz[i, columnaFin]);
            }
            columnaFin--;

            // Recorrer de derecha a izquierda (fila inferior)
            if (filaInicio <= filaFin)
            {
                for (int j = columnaFin; j >= columnaInicio; j--)
                {
                    resultado.Add(matriz[filaFin, j]);
                }
                filaFin--;
            }

            // Recorrer de abajo a arriba (columna izquierda)
            if (columnaInicio <= columnaFin)
            {
                for (int i = filaFin; i >= filaInicio; i--)
                {
                    resultado.Add(matriz[i, columnaInicio]);
                }
                columnaInicio++;
            }
        }

        return resultado;
    }

    public static void ImprimirMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            Console.Write("[");
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j].ToString().PadLeft(3));
                if (j < columnas - 1) Console.Write(", ");
            }
            Console.WriteLine("]");
        }
    }
}