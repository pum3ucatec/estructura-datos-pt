// ## 5. Intersección de Dos Arreglos
// Dado dos arreglos de enteros, encuentra los elementos comunes sin usar LINQ.  
// Ejemplo: `[1,2,2,1]` y `[2,2]` → `[2,2]`.
// Camii
using System;

class Ejercicio5
{
    static void Main()
    {
        int[] arr1 = { 1, 2, 2, 1 };
        int[] arr2 = { 2, 2 };

        Console.WriteLine("Intersección:");
        foreach (int num1 in arr1)
        {
            for (int j = 0; j < arr2.Length; j++)
            {
                if (num1 == arr2[j])
                {
                    Console.Write(num1 + " ");
                    arr2[j] = int.MinValue; // marcar como usado
                    break;
                }
            }
        }
    }
}


