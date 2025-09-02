using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] arr = {2, 3, 6, 7};
        int target = 7;
        List<int> subset = new List<int>();

        Console.WriteLine("Subconjuntos cuya suma es " + target + ":");
        FindSubsets(arr, 0, subset, 0, target);
    }

    static void FindSubsets(int[] arr, int index, List<int> subset, int currentSum, int target)
    {
        // Si la suma actual es igual al target, mostramos el subconjunto
        if (currentSum == target)
        {
            Console.WriteLine("[" + string.Join(", ", subset) + "]");
            return;
        }

        // Si superamos el target o llegamos al final del arreglo, no hacemos nada
        if (currentSum > target || index == arr.Length)
            return;

        // Opción 1: incluir el elemento actual
        subset.Add(arr[index]);
        FindSubsets(arr, index + 1, subset, currentSum + arr[index], target);

        // Opción 2: no incluir el elemento actual (retrocedemos)
        subset.RemoveAt(subset.Count - 1);
        FindSubsets(arr, index + 1, subset, currentSum, target);
    }
}
