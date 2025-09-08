using System;
using System.Collections.Generic;

class Program
{
    static void SubsetSum(int[] arr, int target, int index, List<int> current, List<List<int>> result)
    {
        if (target == 0)
        {
            result.Add(new List<int>(current));
            return;
        }
        if (target < 0 || index == arr.Length) return;

        // incluir arr[index]
        current.Add(arr[index]);
        SubsetSum(arr, target - arr[index], index + 1, current, result);
        current.RemoveAt(current.Count - 1);

        // no incluir arr[index]
        SubsetSum(arr, target, index + 1, current, result);
    }

    static void Main()
    {
        int[] arr = {2, 3, 6, 7};
        List<List<int>> result = new List<List<int>>();
        SubsetSum(arr, 7, 0, new List<int>(), result);

        Console.WriteLine("Subconjuntos que suman 7:");
        foreach (var subset in result)
            Console.WriteLine("[" + string.Join(", ", subset) + "]");
    }
}
