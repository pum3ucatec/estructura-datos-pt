using System;

class Programa
{
    static void Main(string[] args)
    {
        // Defino la matriz
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Recorrido en espiral:");
        RecorrerEspiral(matriz);
    }

    static void RecorrerEspiral(int[,] matriz)
    {
        int arriba = 0;
        int abajo = matriz.GetLength(0) - 1;
        int izquierda = 0;
        int derecha = matriz.GetLength(1) - 1;

        // mientras haya filas y columnas por recorrer
        while (arriba <= abajo && izquierda <= derecha)
        {
            // recorrer de izquierda a derecha
            for (int i = izquierda; i <= derecha; i++)
            {
                Console.Write(matriz[arriba, i] + " ");
            }
            arriba++;

            // recorrer de arriba a abajo
            for (int i = arriba; i <= abajo; i++)
            {
                Console.Write(matriz[i, derecha] + " ");
            }
            derecha--;

            // recorrer de derecha a izquierda
            if (arriba <= abajo)
            {
                for (int i = derecha; i >= izquierda; i--)
                {
                    Console.Write(matriz[abajo, i] + " ");
                }
                abajo--;
            }

            // recorrer de abajo a arriba
            if (izquierda <= derecha)
            {
                for (int i = abajo; i >= arriba; i--)
                {
                    Console.Write(matriz[i, izquierda] + " ");
                }
                izquierda++;
            }
        }
    }
}
