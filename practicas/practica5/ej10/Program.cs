using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] arr = { 2, 3, 6, 7 };
        int target = 7;

        Console.WriteLine("Arreglo: " + string.Join(", ", arr));
        Console.WriteLine("Target: " + target);
        Console.WriteLine("\nSubconjuntos cuya suma es igual al target:");

        List<int> subset = new List<int>();
        EncontrarSubconjuntos(arr, target, 0, subset);
    }

    static void EncontrarSubconjuntos(int[] arr, int target, int start, List<int> subset)
    {
        if (target == 0)
        {
            Console.WriteLine("[{0}]", string.Join(", ", subset));
            return;
        }

        if (target < 0)
            return;

        for (int i = start; i < arr.Length; i++)
        {
            subset.Add(arr[i]);
            // Se permite reutilizar el mismo número (i en lugar de i+1)
            EncontrarSubconjuntos(arr, target - arr[i], i, subset);
            subset.RemoveAt(subset.Count - 1); // backtracking
        }
    }
}
