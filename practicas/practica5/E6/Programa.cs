using System;

class MatrizTranspuesta
{
    static void Main(string[] args)
    {
        int[,] numeros = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        Console.WriteLine("Matriz original:");
        ImprimirMatriz(numeros);

        int[,] resultado = Transponer(numeros);

        Console.WriteLine("\nMatriz transpuesta:");
        ImprimirMatriz(resultado);
    }

    static int[,] Transponer(int[,] arr)
    {
        int filas = arr.GetLength(0);
        int columnas = arr.GetLength(1);

        int[,] nuevo = new int[columnas, filas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                nuevo[j, i] = arr[i, j];
            }
        }

        return nuevo;
    }

    static void ImprimirMatriz(int[,] arr)
    {
        int filas = arr.GetLength(0);
        int columnas = arr.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
