// Dado un arreglo de enteros (puede contener positivos y negativos), encuentra el 
//subarreglo contiguo con la suma más grande.  
// Ejemplo: `[−2, 1, −3, 4, −1, 2, 1, −5, 4]` → el subarreglo `[4, −1, 2, 1]` tiene suma máxima `6`.
using System;

class Ejercicio2
{
    static void Main()
    {
        int[] numeros = { -9, 1, -2, 4, -1, 7, 1, -6, 5 };

        int maxSum = int.MinValue;
        int currentSum = 0;
        int start = 0, end = 0, tempStart = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            currentSum += numeros[i];

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                start = tempStart;
                end = i;
            }

            if (currentSum < 0)
            {
                currentSum = 0;
                tempStart = i + 1;
            }
        }

        Console.WriteLine("Suma máxima: " + maxSum);
        Console.Write("Subarreglo: ");
        for (int i = start; i <= end; i++)
        {
            Console.Write(numeros[i] + " ");
        }
    }
}
