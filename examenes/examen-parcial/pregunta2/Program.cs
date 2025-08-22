// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        List<int> resultado = RecorrerEspiral(matriz);

        Console.WriteLine("Recorrido en espiral: ");
        Console.WriteLine(string.Join(", ", resultado));
    }

    static List<int> RecorrerEspiral(int[,] matriz)
    {
        List<int> lista = new List<int>();

        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        int arriba = 0, abajo = filas - 1;
        int izquierda = 0, derecha = columnas - 1;

        while (arriba <= abajo && izquierda <= derecha)
        {
            for (int i = izquierda; i <= derecha; i++)
                lista.Add(matriz[arriba, i]);
            arriba++;

            for (int i = arriba; i <= abajo; i++)
                lista.Add(matriz[i, derecha]);
            derecha--;

            if (arriba <= abajo)
            {
                for (int i = derecha; i >= izquierda; i--)
                    lista.Add(matriz[abajo, i]);
                abajo--;
            }
            
            if (izquierda <= derecha)
            {
                for (int i = abajo; i >= arriba; i--)
                    lista.Add(matriz[i, izquierda]);
                izquierda++;
            }
        }

        return lista;
    }
}
