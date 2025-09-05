/*
## 2. Subarreglo con Suma Máxima (Kadane’s Algorithm)
Dado un arreglo de enteros (puede contener positivos y negativos), encuentra el subarreglo contiguo con la suma más grande.  
Ejemplo: `[−2, 1, −3, 4, −1, 2, 1, −5, 4]` → el subarreglo `[4, −1, 2, 1]` tiene suma máxima `6`.
*/

using System;

class Ejercicio2
{
    static void Main()
    {
        int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

        int maxActual = arr[0];
        int maxGlobal = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            // Elegir entre el número actual o sumarlo al subarreglo
            maxActual = Math.Max(arr[i], maxActual + arr[i]);

            if (maxActual > maxGlobal)
                maxGlobal = maxActual;
        }

        Console.WriteLine("La suma máxima: " + maxGlobal);
    }
}