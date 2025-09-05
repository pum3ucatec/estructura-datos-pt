//Declara una matriz de 3x3, inicialízala con valores y muestra la suma de cada fila y cada columna.  

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

        Console.WriteLine("Matriz 3x3:");
        for (int fila = 0; fila < 3; fila++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write(matriz[fila, col] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nSuma de cada fila:");
        for (int fila = 0; fila < 3; fila++)
        {
            int sumaFila = 0;
            for (int col = 0; col < 3; col++)
            {
                sumaFila += matriz[fila, col];
            }
            Console.WriteLine($"Fila {fila + 1}: {sumaFila}");
        }

        Console.WriteLine("\nSuma de cada columna:");
        for (int col = 0; col < 3; col++)
        {
            int sumaColumna = 0;
            for (int fila = 0; fila < 3; fila++)
            {
                sumaColumna += matriz[fila, col];
            }
            Console.WriteLine($"Columna {col + 1}: {sumaColumna}");
        }
    }
}


