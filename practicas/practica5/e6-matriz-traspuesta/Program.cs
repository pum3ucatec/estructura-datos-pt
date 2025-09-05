using System;

class MatrizTranspuesta
{
    public static int[,] TransponerMatriz(int[,] matriz)
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

    public static void ImprimirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static void Main()
    {
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6}
        };
        
        Console.WriteLine("Matriz original:");
        ImprimirMatriz(matriz);
        
        Console.WriteLine("\nMatriz transpuesta:");
        int[,] transpuesta = TransponerMatriz(matriz);
        ImprimirMatriz(transpuesta);
    }
}