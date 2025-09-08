// Ejercicio 10: Calcular suma de filas y columnas de una matriz 3x3
// Camii
using System;

class Program
{
    static void Main()
    {
        // Definimos la matriz 3x3
        int[,] matriz = { {1,2,3}, {4,5,6}, {7,8,9} };

        // Recorremos filas
        Console.WriteLine("Suma de filas:");
        for (int i = 0; i < 3; i++)
        {
            int sumFila = 0;
            for (int j = 0; j < 3; j++)
            {
                sumFila += matriz[i, j];
            }
            Console.WriteLine($"Fila {i+1}: {sumFila}");
        }

        // Recorremos columnas
        Console.WriteLine("Suma de columnas:");
        for (int j = 0; j < 3; j++)
        {
            int sumCol = 0;
            for (int i = 0; i < 3; i++)
            {
                sumCol += matriz[i, j];
            }
            Console.WriteLine($"Columna {j+1}: {sumCol}");
        }
    }
}

