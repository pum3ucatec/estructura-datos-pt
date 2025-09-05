// Dado un arreglo de enteros y un número `target`, encuentra todos los subconjuntos cuya suma sea igual al `target`.  
using System;
using System.Collections.Generic;

class Programa
{
    static void Main()
    {
        int[] arreglo = { 2, 3, 6, 7 };
        int target = 7;

        Console.WriteLine($"Subconjuntos que suman {target}:");
        List<List<int>> resultados = new List<List<int>>();
        EncontrarSubconjuntos(arreglo, target, new List<int>(), 0, resultados);

        foreach (var subconjunto in resultados)
        {
            Console.WriteLine("[ " + string.Join(", ", subconjunto) + " ]");
        }
    }

    static void EncontrarSubconjuntos(int[] nums, int target, List<int> actual, int indice, List<List<int>> resultados)
    {
        if (target == 0)
        {
            resultados.Add(new List<int>(actual));
            return;
        }

        for (int i = indice; i < nums.Length; i++)
        {
            if (nums[i] <= target)
            {
                actual.Add(nums[i]);
                EncontrarSubconjuntos(nums, target - nums[i], actual, i, resultados); 
                actual.RemoveAt(actual.Count - 1); 
            }
        }
    }
}

