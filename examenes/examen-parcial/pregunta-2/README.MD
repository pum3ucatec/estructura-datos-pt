# 📘 Programa en C#: Recorrido en Espiral de una Matriz

Este programa en **C#** recorre una matriz en orden **espiral** y devuelve los elementos en ese orden.  
La espiral comienza desde la esquina superior izquierda y sigue este patrón:  
➡️ Derecha → ⬇️ Abajo → ⬅️ Izquierda → ⬆️ Arriba (repitiéndose hasta recorrer todos los elementos).

---

## 📝 Código en C#

```csharp
using System;
using System.Collections.Generic;

class Program
{
    // Método para recorrer una matriz en espiral
    static List<int> RecorrerEspiral(int[,] matriz)
    {
        List<int> resultado = new List<int>();

        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        int inicioFila = 0, finFila = filas - 1;
        int inicioCol = 0, finCol = columnas - 1;

        // Mientras aún existan filas y columnas por recorrer
        while (inicioFila <= finFila && inicioCol <= finCol)
        {
            // 🔹 Recorrer la fila superior de izquierda a derecha
            for (int col = inicioCol; col <= finCol; col++)
            {
                resultado.Add(matriz[inicioFila, col]);
            }
            inicioFila++;

            // 🔹 Recorrer la columna derecha de arriba a abajo
            for (int fila = inicioFila; fila <= finFila; fila++)
            {
                resultado.Add(matriz[fila, finCol]);
            }
            finCol--;

            // 🔹 Recorrer la fila inferior de derecha a izquierda
            if (inicioFila <= finFila)
            {
                for (int col = finCol; col >= inicioCol; col--)
                {
                    resultado.Add(matriz[finFila, col]);
                }
                finFila--;
            }

            // 🔹 Recorrer la columna izquierda de abajo a arriba
            if (inicioCol <= finCol)
            {
                for (int fila = finFila; fila >= inicioFila; fila--)
                {
                    resultado.Add(matriz[fila, inicioCol]);
                }
                inicioCol++;
            }
        }

        return resultado;
    }

    static void Main()
    {
        // Matriz de ejemplo
        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Obtener recorrido en espiral
        List<int> espiral = RecorrerEspiral(matriz);

        // Mostrar resultado
        Console.WriteLine("Elementos en espiral:");
        Console.WriteLine(string.Join(", ", espiral));
    }
}
