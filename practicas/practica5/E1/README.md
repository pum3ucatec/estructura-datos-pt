# Rotación de Arreglo en C#

Este programa realiza la rotación de un arreglo de números enteros hacia la derecha una cantidad determinada de posiciones.

## Descripción

Se tiene un arreglo inicial de enteros y un valor `k` que indica cuántas posiciones se debe rotar el arreglo.  
El algoritmo recorre cada elemento y lo coloca en su nueva posición utilizando la fórmula:


donde:
- `i` es el índice actual del elemento.
- `k` es el número de posiciones a rotar.
- `n` es la longitud del arreglo.

## Código

```csharp
using System;

class RotacionArreglo
{
    static void Main(string[] args)
    {
        int[] Numeros = { 1, 2, 3, 4, 5 };
        int K = 2;

        int[] Resultado = Rotar(Numeros, K);

        Console.WriteLine("Arreglo rotado:");
        for (int i = 0; i < Resultado.Length; i++)
        {
            Console.Write(Resultado[i] + " ");
        }
        Console.WriteLine();
    }

    static int[] Rotar(int[] Arreglo, int K)
    {
        int N = Arreglo.Length;
        int[] Nuevo = new int[N];

        for (int i = 0; i < N; i++)
        {
            int NuevaPos = (i + K) % N;
            Nuevo[NuevaPos] = Arreglo[i];
        }

        return Nuevo;
    }
}

Arreglo: [1, 2, 3, 4, 5]
k = 2

Arreglo rotado:
4 5 1 2 3
