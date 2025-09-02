// Dada una **matriz** (arreglo bidimensional), encuentra su transpuesta.  

using System;

class Ejercicio6
{
    static void Main()
    {
        int[,] matriz = { { 6, 7, 8 }, { 9, 11, 10 } };
        int filas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        Console.WriteLine("Matriz bidimensional:");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        int[,] transpuesta = new int[cols, filas];
        for (int i = 0; i < filas; i++)
            for (int j = 0; j < cols; j++)
                transpuesta[j, i] = matriz[i, j];

        Console.WriteLine("Matriz transpuesta:");
        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < filas; j++)
                Console.Write(transpuesta[i, j] + " ");
            Console.WriteLine();
        }
    }
}