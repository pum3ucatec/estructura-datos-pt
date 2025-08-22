using System;
using System.Collections.Generic;

class EspiralMatriz
{
    static void Main()
    {
        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        List<int> resultado = RecorrerEspiral(matriz);

        Console.WriteLine("Recorrido en espiral:");
        Console.WriteLine($"[{string.Join(", ", resultado)}]");
    }

    static List<int> RecorrerEspiral(int[,] matriz)
    {
        List<int> espiral = new List<int>();

        int filaInicial = 0;
        int filaFinal = matriz.GetLength(0) - 1;
        int columnaInicial = 0;
        int columnaFinal = matriz.GetLength(1) - 1;

        while (filaInicial <= filaFinal && columnaInicial <= columnaFinal)
        {
            // Recorre izquierda → derecha
            for (int col = columnaInicial; col <= columnaFinal; col++)
                espiral.Add(matriz[filaInicial, col]);
            filaInicial++;

            // Recorre arriba → abajo
            for (int fila = filaInicial; fila <= filaFinal; fila++)
                espiral.Add(matriz[fila, columnaFinal]);
            columnaFinal--;

            // Recorre derecha → izquierda
            if (filaInicial <= filaFinal)
            {
                for (int col = columnaFinal; col >= columnaInicial; col--)
                    espiral.Add(matriz[filaFinal, col]);
                filaFinal--;
            }

            // Recorre abajo → arriba
            if (columnaInicial <= columnaFinal)
            {
                for (int fila = filaFinal; fila >= filaInicial; fila--)
                    espiral.Add(matriz[fila, columnaInicial]);
                columnaInicial++;
            }
        }

        return espiral;
    }
}