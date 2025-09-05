using System;
using System.Collections.Generic;

class SumaSubconjuntos
{
    public static List<List<int>> SubconjuntosSuma(int[] arr, int target)
    {
        Array.Sort(arr);
        List<List<int>> resultado = new List<List<int>>();
        Backtrack(arr, target, 0, new List<int>(), resultado);
        return resultado;
    }

    private static void Backtrack(int[] arr, int target, int inicio,
                                List<int> caminoActual, List<List<int>> resultado)
    {
        if (target == 0)
        {
            resultado.Add(new List<int>(caminoActual));
            return;
        }

        for (int i = inicio; i < arr.Length; i++)
        {
            if (i > inicio && arr[i] == arr[i - 1]) continue;

            if (arr[i] > target) break;

            caminoActual.Add(arr[i]);
            Backtrack(arr, target - arr[i], i + 1, caminoActual, resultado);
            caminoActual.RemoveAt(caminoActual.Count - 1);
        }
    }

    public static void Main()
    {
        int[] arr = { 2, 3, 6, 7 };
        int target = 5;

        Console.WriteLine("Arreglo: " + string.Join(", ", arr));
        Console.WriteLine("Target: " + target);

        List<List<int>> resultado = SubconjuntosSuma(arr, target);

        Console.WriteLine("Subconjuntos que suman " + target + ":");
        foreach (var subconjunto in resultado)
        {
            Console.WriteLine("[" + string.Join(", ", subconjunto) + "]");
        }
    }
}
