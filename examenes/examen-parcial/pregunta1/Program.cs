// Espiral en una Matriz Escribe un programa que recorra e imprima los elementos de una matriz en forma de espiral. 
// Ejemplo: [ [1, 2, 3], [4, 5, 6], [7, 8, 9] ] → [1, 2, 3, 6, 9, 8, 7, 4, 5].
// Camiii
using System;

class Pregunta1
{
    static void Main()
    {
        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int filaInicio = 0, filaFin = 2, colInicio = 0, colFin = 2;

        Console.Write("La matriz de una forma espiral es de esta manera: ");
        while (filaInicio <= filaFin && colInicio <= colFin)
        {
            // de izquierda -> derecha
            for (int i = colInicio; i <= colFin; i++)
                Console.Write(matriz[filaInicio, i] + " ");
            filaInicio++;

            // de arriba -> abajo
            for (int i = filaInicio; i <= filaFin; i++)
                Console.Write(matriz[i, colFin] + " ");
            colFin--;

            if (filaInicio <= filaFin)
            {
                // de derecha -> izquierda
                for (int i = colFin; i >= colInicio; i--)
                    Console.Write(matriz[filaFin, i] + " ");
                filaFin--;
            }

            if (colInicio <= colFin)
            {
                // de abajo -> arriba
                for (int i = filaFin; i >= filaInicio; i--)
                    Console.Write(matriz[i, colInicio] + " ");
                colInicio++;
            }
        }
    }
}