using System;

class Program
{
    static void Main(string[] args)
    {
        // Matriz de ejemplo (2x3)
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6}
        };

        Console.WriteLine("Matriz original:");
        ImprimirMatriz(matriz);

        // Calcular la transpuesta
        int[,] transpuesta = Transponer(matriz);

        Console.WriteLine("\nMatriz transpuesta:");
        ImprimirMatriz(transpuesta);
    }

    // Método que calcula la transpuesta
    static int[,] Transponer(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        int[,] resultado = new int[columnas, filas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                resultado[j, i] = matriz[i, j];
            }
        }

        return resultado;
    }

    // Método para imprimir una matriz
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
