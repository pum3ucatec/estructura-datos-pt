using System;

class Program
{
    static int MaxSubarraySum(int[] arr)
    {
        int maxSoFar = arr[0], current = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            current = Math.Max(arr[i], current + arr[i]);
            maxSoFar = Math.Max(maxSoFar, current);
        }
        return maxSoFar;
    }

    static void Main()
    {
        int[] arr = {-2, 1, -3, 4, -1, 2, 1, -5, 4};
        Console.WriteLine("Suma máxima: " + MaxSubarraySum(arr));
    }
}
