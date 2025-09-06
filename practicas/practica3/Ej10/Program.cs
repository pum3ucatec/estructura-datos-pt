// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int[,] Matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int Filas = Matriz.GetLength(0);
        int Columnas = Matriz.GetLength(1);

        Console.WriteLine("Matriz:\n");
        for (int i = 0; i < Filas; i++)
        {
            for (int j = 0; j < Columnas; j++)
            {
                Console.Write(Matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nSuma de filas:");
        for (int i = 0; i < Filas; i++)
        {
            int SumaFila = 0;
            for (int j = 0; j < Columnas; j++)
            {
                SumaFila += Matriz[i, j];
            }
            Console.WriteLine("Fila " + (i + 1) + ": " + SumaFila);
        }

        Console.WriteLine("\nSuma de columnas:");
        for (int j = 0; j < Columnas; j++)
        {
            int SumaColumna = 0;
            for (int i = 0; i < Filas; i++)
            {
                SumaColumna += Matriz[i, j];
            }
            Console.WriteLine("Columna " + (j + 1) + ": " + SumaColumna);
        }
    }
}


