/* 10. Arreglo bidimensional (matriz)
Declara una matriz de 3x3, inicialízala con valores y muestra la suma de cada fila y cada columna. */

using System;

class Ejercicio10
{
    static void Main()
    {
        int[,] matriz = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int filas = matriz.GetLength(0); 
        int columnas = matriz.GetLength(1);

        Console.WriteLine("Suma de filas:");
        for (int f = 0; f < filas; f++)
        {
            int sumaFila = 0;
            for (int c = 0; c < columnas; c++)
            {
                sumaFila += matriz[f, c];
            }
            Console.WriteLine($"Fila {f + 1}: {sumaFila}");
        }

        Console.WriteLine("\nSuma de columnas:");
        for (int c = 0; c < columnas; c++)
        {
            int sumaCol = 0;
            for (int f = 0; f < filas; f++)
            {
                sumaCol += matriz[f, c];
            }
            Console.WriteLine($"Columna {c + 1}: {sumaCol}");
        }
    }
}
