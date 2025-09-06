using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 2, 3, 6, 7 };
        int target = 7;

        Console.WriteLine("Arreglo: [" + string.Join(", ", nums) + "]");
        Console.WriteLine("Target: " + target);
        Console.WriteLine("\nSubconjuntos que suman al target:");

        List<List<int>> resultados = new List<List<int>>();
        List<int> actual = new List<int>();

        Backtracking(nums, target, 0, actual, resultados);

        foreach (var subconjunto in resultados)
        {
            Console.WriteLine("[" + string.Join(", ", subconjunto) + "]");
        }
    }

    // Método Backtracking
    static void Backtracking(int[] nums, int target, int inicio, List<int> actual, List<List<int>> resultados)
    {
        if (target == 0)
        {
            resultados.Add(new List<int>(actual));
            return;
        }

        for (int i = inicio; i < nums.Length; i++)
        {
            if (nums[i] <= target)
            {
                actual.Add(nums[i]);                  // Elegir
                Backtracking(nums, target - nums[i], i, actual, resultados); // Reusar mismo número
                actual.RemoveAt(actual.Count - 1);    // Retroceder (backtrack)
            }
        }
    }
}
