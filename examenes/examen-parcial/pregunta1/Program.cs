using System;
using System.Collections.Generic;

namespace examenparcial
{
    class Program
    {
        static void Main(string[] args){
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        List<int> resultado = RecorrerEspiral(matriz);

        Console.WriteLine("Recorrido en espiral:");
        Console.WriteLine(string.Join(", ", resultado));
    }

    static List<int> RecorrerEspiral(int[,] matriz)
    {
        List<int> resultado = new List<int>();
        if (matriz == null || matriz.Length == 0) return resultado;

        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        int arriba = 0, abajo = filas - 1;
        int izquierda = 0, derecha = columnas - 1;

        while (arriba <= abajo && izquierda <= derecha)
        {
            for (int j = izquierda; j <= derecha; j++)
                resultado.Add(matriz[arriba, j]);
                arriba++;

            for (int i = arriba; i <= abajo; i++)
                resultado.Add(matriz[i, derecha]);
                derecha--;

            if (arriba <= abajo)
            {
                for (int j = derecha; j >= izquierda; j--)
                    resultado.Add(matriz[abajo, j]);
                    abajo--;
            }

            if (izquierda <= derecha)
            {
                for (int i = abajo; i >= arriba; i--)
                    resultado.Add(matriz[i, izquierda]);
                    izquierda++;
            }
        }
            return resultado;
        }
    }

}
