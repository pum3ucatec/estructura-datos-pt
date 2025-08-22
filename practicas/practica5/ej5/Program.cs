using System;
using System.Collections.Generic;

class Program
{
    static List<int> Intersection(int[] arr1, int[] arr2)
    {
        List<int> result = new List<int>();
        bool[] used = new bool[arr2.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr2.Length; j++)
            {
                if (!used[j] && arr1[i] == arr2[j])
                {
                    result.Add(arr1[i]);
                    used[j] = true;
                    break;
                }
            }
        }
        return result;
    }

    static void Main()
    {
        int[] arr1 = {1, 2, 2, 1};
        int[] arr2 = {2, 2};
        Console.WriteLine("Intersección: " + string.Join(", ", Intersection(arr1, arr2)));
    }
}
