using System;
using System.Collections.Generic;

class Pregunta2
{
    static void Main(string[] args)
    {
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        List<int> result = OrdenEspiral(matrix);

        Console.WriteLine("Recorrido en espiral:");
        Console.WriteLine(string.Join(", ", result));
    }

    static List<int> OrdenEspiral (int[,] matrix)
    {
        List<int> result = new List<int>();

        if (matrix == null || matrix.Length == 0)
            return result;

        int arriba = 0;
        int abajo = matrix.GetLength(0) - 1;
        int izq = 0;
        int der = matrix.GetLength(1) - 1;

        while (arriba <= abajo && izq <= der)
        {
            // Recorre de izquierda a derecha
            for (int i = izq; i <= der; i++)
                result.Add(matrix[arriba, i]);
            arriba++;

            // Recorre de arriba hacia abajo
            for (int i = arriba; i <= abajo; i++)
                result.Add(matrix[i, der]);
            der--;

            // Recorre de derecha a izquierda (si queda fila)
            if (arriba <= abajo)
            {
                for (int i = der; i >= izq; i--)
                    result.Add(matrix[abajo, i]);
                abajo--;
            }

            // Recorre de abajo hacia arriba (si queda columna)
            if (izq <= der)
            {
                for (int i = abajo; i >= arriba; i--)
                    result.Add(matrix[i, izq]);
                izq++;
            }
        }

        return result;
    }
}
