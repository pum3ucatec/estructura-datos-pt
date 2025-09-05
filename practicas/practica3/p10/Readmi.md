# Ejercicio 10 - Sumar filas y columnas de una matriz en C#

## 📌 Descripción
Este programa en C# trabaja con una **matriz de 3x3** y realiza las siguientes operaciones:  
1. Mostrar la matriz completa.  
2. Calcular y mostrar la **suma de cada fila**.  
3. Calcular y mostrar la **suma de cada columna**.  

El objetivo es practicar el manejo de **matrices bidimensionales** y bucles anidados.

---

## 💻 Código

```csharp
using System;

class Ejercicio10
{
    static void Main()
    {
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Matriz:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
                Console.Write(matriz[i, j] + " ");
            Console.WriteLine();
        }

        Console.WriteLine("Suma de filas:");
        for (int i = 0; i < 3; i++)
        {
            int sumaFila = 0;
            for (int j = 0; j < 3; j++)
                sumaFila += matriz[i, j];
            Console.WriteLine($"Fila {i + 1}: {sumaFila}");
        }

        Console.WriteLine("Suma de columnas:");
        for (int j = 0; j < 3; j++)
        {
            int sumaColumna = 0;
            for (int i = 0; i < 3; i++)
                sumaColumna += matriz[i, j];
            Console.WriteLine($"Columna {j + 1}: {sumaColumna}");
        }
    }
}

📖 Explicación

Se define una matriz bidimensional matriz de 3x3 con valores del 1 al 9.

Para mostrar la matriz, se usan dos bucles anidados: el bucle externo recorre las filas y el bucle interno recorre las columnas.

Para sumar las filas, se recorre cada fila y se acumulan los valores en sumaFila.

Para sumar las columnas, se recorre cada columna y se acumulan los valores en sumaColumna.

Finalmente, se imprime en consola la matriz y las sumas correspondientes de filas y columnas.

▶️ Ejemplo de salida

Matriz:
1 2 3 
4 5 6 
7 8 9 
Suma de filas:
Fila 1: 6
Fila 2: 15
Fila 3: 24
Suma de columnas:
Columna 1: 12
Columna 2: 15
Columna 3: 18