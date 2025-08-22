// Espiral en una Matriz Escribe un programa que recorra e imprima los elementos de una matriz en forma de espiral. 
// Ejemplo: [ [1, 2, 3], [4, 5, 6], [7, 8, 9] ] → [1, 2, 3, 6, 9, 8, 7, 4, 5].

using System;

class Pregunta1
{
    static void Main()
    {
        Console.Write("Ingrese el número de filas: ");
        int filas = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el número de columnas: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matriz = new int[filas, cols];


        Console.WriteLine("Ingrese los elementos de la matriz:");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        
        Console.WriteLine("\nMatriz original:");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nRecorrido en espiral:");
        int top = 0, bottom = filas - 1, left = 0, right = cols - 1;

        while (top <= bottom && left <= right)
        {
            for (int i = left; i <= right; i++) Console.Write(matriz[top, i] + " ");
            top++;

            for (int i = top; i <= bottom; i++) Console.Write(matriz[i, right] + " ");
            right--;

            if (top <= bottom)
            {
                for (int i = right; i >= left; i--) Console.Write(matriz[bottom, i] + " ");
                bottom--;
            }

            if (left <= right)
            {
                for (int i = bottom; i >= top; i--) Console.Write(matriz[i, left] + " ");
                left++;
            }
        }
    }
}
