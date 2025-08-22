using System;
using System.Collections.Generic;

class EspiralMatriz
{
    static void Main(string[] args)
    {
        // Definimos la matriz de ejemplo
        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Llamamos al método que recorre la matriz en espiral
        List<int> resultado = RecorrerEnEspiral(matriz);

        // Imprimimos el resultado
        Console.WriteLine("Recorrido en espiral:");
        Console.WriteLine("[" + string.Join(", ", resultado) + "]");
    }

    // Método para recorrer en espiral
    static List<int> RecorrerEnEspiral(int[,] matriz)
    {
        List<int> resultado = new List<int>();
        int filaInicio = 0;
        int filaFin = matriz.GetLength(0) - 1;
        int colInicio = 0;
        int colFin = matriz.GetLength(1) - 1;

        while (filaInicio <= filaFin && colInicio <= colFin)
        {
            // Recorrer fila superior
            for (int i = colInicio; i <= colFin; i++)
                resultado.Add(matriz[filaInicio, i]);
            filaInicio++;

            // Recorrer columna derecha
            for (int i = filaInicio; i <= filaFin; i++)
                resultado.Add(matriz[i, colFin]);
            colFin--;

            // Recorrer fila inferior (si queda)
            if (filaInicio <= filaFin)
            {
                for (int i = colFin; i >= colInicio; i--)
                    resultado.Add(matriz[filaFin, i]);
                filaFin--;
            }

            // Recorrer columna izquierda (si queda)
            if (colInicio <= colFin)
            {
                for (int i = filaFin; i >= filaInicio; i--)
                    resultado.Add(matriz[i, colInicio]);
                colInicio++;
            }
        }

        return resultado;
    }
}
