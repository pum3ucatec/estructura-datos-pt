using System;

class Program
{
    static void Main(string[] args)
    {
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
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        int arriba = 0, abajo = filas - 1;
        int izquierda = 0, derecha = columnas - 1;

        while (arriba <= abajo && izquierda <= derecha)
        {
            // Recorrer de izquierda a derecha
            for (int i = izquierda; i <= derecha; i++)
                Console.Write(matriz[arriba, i] + " ");
            arriba++;

            // Recorrer de arriba hacia abajo
            for (int i = arriba; i <= abajo; i++)
                Console.Write(matriz[i, derecha] + " ");
            derecha--;

            // Recorrer de derecha a izquierda
            if (arriba <= abajo)
            {
                for (int i = derecha; i >= izquierda; i--)
                    Console.Write(matriz[abajo, i] + " ");
                abajo--;
            }

            // Recorrer de abajo hacia arriba
            if (izquierda <= derecha)
            {
                for (int i = abajo; i >= arriba; i--)
                    Console.Write(matriz[i, izquierda] + " ");
                izquierda++;
            }
        }
    }
}
