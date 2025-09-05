using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 2, 3, 6, 7 };
        int target = 7;
        List<List<int>> resultados = new List<List<int>>();
        List<int> actual = new List<int>();

        EncontrarSubconjuntos(nums, target, 0, actual, resultados);

        Console.WriteLine($"Subconjuntos cuya suma es {target}:");
        foreach (var subconjunto in resultados)
        {
            Console.WriteLine("[{0}]", string.Join(", ", subconjunto));
        }
    }

    static void EncontrarSubconjuntos(int[] nums, int target, int inicio, List<int> actual, List<List<int>> resultados)
    {
        if (target == 0)
        {
            resultados.Add(new List<int>(actual));
            return;
        }
        if (target < 0)
            return;

        for (int i = inicio; i < nums.Length; i++)
        {
            actual.Add(nums[i]);
            // Permite reutilizar el mismo número varias veces
            EncontrarSubconjuntos(nums, target - nums[i], i, actual, resultados);
            actual.RemoveAt(actual.Count - 1);
        }
    }
}