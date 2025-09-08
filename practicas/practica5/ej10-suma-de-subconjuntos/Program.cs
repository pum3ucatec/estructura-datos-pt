// ## 10. Suma de Subconjuntos (Backtracking)
// Dado un arreglo de enteros y un número `target`, encuentra todos los subconjuntos cuya suma sea igual al `target`.  
// Ejemplo: `[2, 3, 6, 7], target=7` → subconjuntos `[7]`, `[2, 2, 3]`.
// Camii

using System;
using System.Collections.Generic;

class Ejercicio10
{
    static void BuscarSubconjuntos(int[] arr, int target, List<int> actual, int index)
    {
        if (target == 0)
        {
            Console.WriteLine("[" + string.Join(", ", actual) + "]");
            return;
        }

        if (target < 0 || index == arr.Length) return;

        // Incluir arr[index]
        actual.Add(arr[index]);
        BuscarSubconjuntos(arr, target - arr[index], actual, index + 1);

        // Excluir arr[index]
        actual.RemoveAt(actual.Count - 1);
        BuscarSubconjuntos(arr, target, actual, index + 1);
    }

    static void Main()
    {
        int[] arr = { 2, 3, 6, 7 };
        int target = 7;

        Console.WriteLine("Subconjuntos con suma = " + target + ":");
        BuscarSubconjuntos(arr, target, new List<int>(), 0);
    }
}
