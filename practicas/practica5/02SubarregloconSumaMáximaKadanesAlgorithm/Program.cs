// Dado un arreglo de enteros (puede contener positivos y negativos), encuentra el subarreglo contiguo con la suma más grande.  
using System;

class Programa
{
    static void Main()
    {
        int[] arreglo = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

        int maxSuma = MaxSubarreglo(arreglo);

        Console.WriteLine("La suma máxima de un subarreglo contiguo es: " + maxSuma);
    }

    static int MaxSubarreglo(int[] arreglo)
    {
        int maxActual = arreglo[0];
        int maxGlobal = arreglo[0];

        for (int i = 1; i < arreglo.Length; i++)
        {
   
            maxActual = Math.Max(arreglo[i], maxActual + arreglo[i]);

            if (maxActual > maxGlobal)
            {
                maxGlobal = maxActual;
            }
        }

        return maxGlobal;
    }
}
