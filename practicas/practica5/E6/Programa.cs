using System;

class MatrizTranspuesta
{
    static void Main(string[] args)
    {
        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        Console.WriteLine("Matriz original:");
        ImprimirMatriz(matriz);

        int[,] transpuesta = Transponer(matriz);

        Console.WriteLine("\nMatriz transpuesta:");
        ImprimirMatriz(transpuesta);
    }

    static int[,] Transponer(int[,] matriz)
    {
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

        return transpuesta;
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
