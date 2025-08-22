using System;
using System.Collections.Generic;

class Program
{
    // Recorre la matriz en forma de espiral y devuelve los valores en una lista
    static List<int> RecorrerEspiral(int[,] matriz)
    {
        List<int> recorrido = new List<int>();
        int arriba = 0, abajo = matriz.GetLength(0) - 1;
        int izquierda = 0, derecha = matriz.GetLength(1) - 1;

        while (arriba <= abajo && izquierda <= derecha)
        {
            // fila de izquierda a derecha
            for (int j = izquierda; j <= derecha; j++)
                recorrido.Add(matriz[arriba, j]);
            arriba++;

            // columna de arriba hacia abajo
            for (int i = arriba; i <= abajo; i++)
                recorrido.Add(matriz[i, derecha]);
            derecha--;

            // fila de derecha a izquierda
            if (arriba <= abajo)
            {
                for (int j = derecha; j >= izquierda; j--)
                    recorrido.Add(matriz[abajo, j]);
                abajo--;
            }

            // columna de abajo hacia arriba
            if (izquierda <= derecha)
            {
                for (int i = abajo; i >= arriba; i--)
                    recorrido.Add(matriz[i, izquierda]);
                izquierda++;
            }
        }

        return recorrido;
    }

    static void Main()
    {
        // La matriz fija
        int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        // El resultado en espiral
        List<int> resultado = RecorrerEspiral(matriz);
        Console.WriteLine("Recorrido en espiral:");
        Console.WriteLine("[ " + string.Join(", ", resultado) + " ]");
    }
}
