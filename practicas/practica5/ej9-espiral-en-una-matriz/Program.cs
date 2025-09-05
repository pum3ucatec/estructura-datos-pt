// ## 9. Espiral en una Matriz
// Escribe un programa que recorra e imprima los elementos de una matriz en forma de espiral.  
// Ejemplo:  
/*
[ [1, 2, 3],
  [4, 5, 6],
  [7, 8, 9] ]
```
→ `[1, 2, 3, 6, 9, 8, 7, 4, 5]`.
*/

using System;

class Ejercicio9
{
    static void Main()
    {
        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int filaInicio = 0, filaFin = 2, colInicio = 0, colFin = 2;

        Console.Write("Espiral: ");
        while (filaInicio <= filaFin && colInicio <= colFin)
        {
            // izquierda -> derecha
            for (int i = colInicio; i <= colFin; i++)
                Console.Write(matriz[filaInicio, i] + " ");
            filaInicio++;

            // arriba -> abajo
            for (int i = filaInicio; i <= filaFin; i++)
                Console.Write(matriz[i, colFin] + " ");
            colFin--;

            if (filaInicio <= filaFin)
            {
                // derecha -> izquierda
                for (int i = colFin; i >= colInicio; i--)
                    Console.Write(matriz[filaFin, i] + " ");
                filaFin--;
            }

            if (colInicio <= colFin)
            {
                // abajo -> arriba
                for (int i = filaFin; i >= filaInicio; i--)
                    Console.Write(matriz[i, colInicio] + " ");
                colInicio++;
            }
        }
    }
}
