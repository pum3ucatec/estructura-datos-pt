using System;

class Program
{
    static void Main()
    {
        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        int[,] transpuesta = new int[columnas, filas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                transpuesta[j, i] = matriz[i, j];
            }
        }

        Console.WriteLine("Matriz original:");
        PrintMatrix(matriz);

        Console.WriteLine("\nMatriz transpuesta:");
        PrintMatrix(transpuesta);
    }

    static void PrintMatrix(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine("]");
        }
    }
}

