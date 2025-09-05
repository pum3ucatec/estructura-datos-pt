using System;

class Program
{
    static void Main()
    {
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Matriz original:");
        ImprimirMatriz(matriz);

        Console.WriteLine("\nRecorrido en espiral:");
        ImprimirEspiral(matriz);
    }

    static void ImprimirEspiral(int[,] matriz)
    {
        int filaInicio = 0, filaFin = matriz.GetLength(0) - 1;
        int colInicio = 0, colFin = matriz.GetLength(1) - 1;

        while (filaInicio <= filaFin && colInicio <= colFin)
        {
            // Recorrer de izquierda a derecha
            for (int i = colInicio; i <= colFin; i++)
                Console.Write(matriz[filaInicio, i] + " ");
            filaInicio++;

            // Recorrer de arriba hacia abajo
            for (int i = filaInicio; i <= filaFin; i++)
                Console.Write(matriz[i, colFin] + " ");
            colFin--;

            // Recorrer de derecha a izquierda
            if (filaInicio <= filaFin)
            {
                for (int i = colFin; i >= colInicio; i--)
                    Console.Write(matriz[filaFin, i] + " ");
                filaFin--;
            }

            // Recorrer de abajo hacia arriba
            if (colInicio <= colFin)
            {
                for (int i = filaFin; i >= filaInicio; i--)
                    Console.Write(matriz[i, colInicio] + " ");
                colInicio++;
            }
        }
    }

    static void ImprimirMatriz(int[,] matriz)
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
}
