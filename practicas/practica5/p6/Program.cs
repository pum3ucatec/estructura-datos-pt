using System;

class Program
{
    static void Main()
    {
        int[,] matriz = { {1, 2, 3}, {4, 5, 6} };
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

        Console.WriteLine("Matriz transpuesta:");
        PrintMatrix(transpuesta);
    }

    static void PrintMatrix(int[,] mat)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write(mat[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
