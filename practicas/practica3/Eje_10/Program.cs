// Declara una matriz de 3x3, inicialízala con valores y muestra la suma de cada fila y cada columna.
using System;
class Program
{
    static void Main()
    {
        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Suma de cada fila
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            int sumaFila = 0;
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                sumaFila += matriz[i, j];
            }
            Console.WriteLine($"Suma de la fila {i + 1}: {sumaFila}");
        }

        // Suma de cada columna
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            int sumaColumna = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                sumaColumna += matriz[i, j];
            }
            Console.WriteLine($"Suma de la columna {j + 1}: {sumaColumna}");
        }
    }
}