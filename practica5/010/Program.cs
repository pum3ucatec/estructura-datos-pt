using System;
using System.Collections.Generic;

class Program
{
    static List<List<int>> SubconjuntosSumaObjetivo(int[] nums, int target)
    {
        Array.Sort(nums);
        var res = new List<List<int>>();
        Backtrack(nums, 0, target, new List<int>(), res);
        return res;
    }
    static void Backtrack(int[] nums, int idx, int resto, List<int> camino, List<List<int>> res)
    {
        if (resto == 0) { res.Add(new List<int>(camino)); return; }
        if (resto < 0) return;

        for (int i = idx; i < nums.Length; i++)
        {
            if (i > idx && nums[i] == nums[i - 1]) continue; // evitar duplicados
            camino.Add(nums[i]);
            Backtrack(nums, i, resto - nums[i], camino, res); // i (reutilización permitida)
            camino.RemoveAt(camino.Count - 1);
        }
    }

    static void Main()
    {
        var sols = SubconjuntosSumaObjetivo(new[] {2,3,6,7}, 7);
        foreach (var s in sols) Console.WriteLine(string.Join(",", s)); // 7 / 2,2,3
    }
}
