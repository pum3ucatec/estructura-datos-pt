# Documentación del Programa de Matriz y Suma de Filas y Columnas en PascalCase

Este programa en C# permite trabajar con una matriz de enteros, mostrando la matriz completa y calculando la suma de cada fila y cada columna.  
El código ha sido convertido al estilo **PascalCase** para las variables, lo que significa que cada nombre comienza con mayúscula.

## Explicación del Código

1. **Declaración de la Matriz:** Se crea una matriz bidimensional `Matriz` con valores iniciales de 3x3.  
2. **Obtención de Dimensiones:**  
   - `Filas` almacena el número de filas de la matriz.  
   - `Columnas` almacena el número de columnas de la matriz.  
3. **Mostrar la Matriz:**  
   - Se recorre la matriz con dos ciclos `for` anidados.  
   - Se imprimen los elementos en forma de tabla.  
4. **Suma de Filas:**  
   - Se recorre cada fila y se suman sus elementos en `SumaFila`.  
   - Se imprime el resultado de cada fila.  
5. **Suma de Columnas:**  
   - Se recorre cada columna y se suman sus elementos en `SumaColumna`.  
   - Se imprime el resultado de cada columna.

## Código en PascalCase

```csharp
using System;

class Program
{
    static void Main()
    {
        int[,] Matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int Filas = Matriz.GetLength(0);
        int Columnas = Matriz.GetLength(1);

        Console.WriteLine("Matriz:\n");
        for (int i = 0; i < Filas; i++)
        {
            for (int j = 0; j < Columnas; j++)
            {
                Console.Write(Matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nSuma de filas:");
        for (int i = 0; i < Filas; i++)
        {
            int SumaFila = 0;
            for (int j = 0; j < Columnas; j++)
            {
                SumaFila += Matriz[i, j];
            }
            Console.WriteLine("Fila " + (i + 1) + ": " + SumaFila);
        }

        Console.WriteLine("\nSuma de columnas:");
        for (int j = 0; j < Columnas; j++)
        {
            int SumaColumna = 0;
            for (int i = 0; i < Filas; i++)
            {
                SumaColumna += Matriz[i, j];
            }
            Console.WriteLine("Columna " + (j + 1) + ": " + SumaColumna);
        }
    }
}
