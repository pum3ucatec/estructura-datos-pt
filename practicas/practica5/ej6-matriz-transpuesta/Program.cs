 // ## 6. Matriz Transpuesta
// Dada una **matriz** (arreglo bidimensional), encuentra su transpuesta.  
// Ejemplo:  
/*
[ [1, 2, 3],
  [4, 5, 6] ]
```
→  
```
[ [1, 4],
  [2, 5],
  [3, 6] ]
```
*/
using System;

class Ejercicio6
{
    static void Main()
    {
        int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 } };
        int filas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        int[,] transpuesta = new int[cols, filas];

        // Intercambiar filas y columnas
        for (int i = 0; i < filas; i++)
            for (int j = 0; j < cols; j++)
                transpuesta[j, i] = matriz[i, j];

        Console.WriteLine("Matriz transpuesta:");
        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < filas; j++)
                Console.Write(transpuesta[i, j] + " ");
            Console.WriteLine();
        }
    }
}

