## **10. Suma de Filas y Columnas en una Matriz**
### Descripción

Este programa demuestra cómo manipular una matriz de 3x3. Se inicializa la matriz con valores fijos y luego se usan bucles anidados para calcular la suma de los elementos de cada fila y de cada columna de manera independiente. El programa imprime cada suma con una etiqueta clara para identificar a qué fila o columna pertenece.
### Código
```
// Se incluye la biblioteca 'System' para usar la consola.
using System;
class Program
{
    static void Main()
    {
        // Se declara e inicializa una matriz de 3x3.
        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Bucle para calcular la suma de cada fila.
        Console.WriteLine("--- Sumas por fila ---");
        // 'matriz.GetLength(0)' devuelve el número de filas (3).
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            int sumaFila = 0;
            // 'matriz.GetLength(1)' devuelve el número de columnas (3).
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                sumaFila += matriz[i, j];
            }
            Console.WriteLine($"Suma de la fila {i + 1}: {sumaFila}");
        }

        // Bucle para calcular la suma de cada columna.
        Console.WriteLine("\n--- Sumas por columna ---");
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            int sumaColumna = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                sumaColumna += matriz[i, j];
            }
            Console.WriteLine($"Suma de la columna {j + 1}: {sumaColumna}");
        }
    }
}
``` 
