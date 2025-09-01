using System;

// Implementación de Kadane's Algorithm
static int MaxSubArray(int[] arr)
{
    int maxHastaAqui = arr[0];
    int maxTotal = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        maxHastaAqui = Math.Max(arr[i], maxHastaAqui + arr[i]);
        maxTotal = Math.Max(maxTotal, maxHastaAqui);
    }

    return maxTotal;
}

Console.WriteLine("Ejercicio 2! Suma Máxima de un Subarreglo");

int[] arreglo = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

Console.WriteLine("Arreglo: " + string.Join(", ", arreglo));

int maxSuma = MaxSubArray(arreglo);

Console.WriteLine("La suma máxima de un subarreglo es: " + maxSuma);
