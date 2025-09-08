﻿using System;

class Program
{
    static int[] ProductExceptSelf(int[] arr)
    {
        int n = arr.Length;
        int[] left = new int[n], right = new int[n], result = new int[n];

        left[0] = 1;
        for (int i = 1; i < n; i++)
            left[i] = left[i - 1] * arr[i - 1];

        right[n - 1] = 1;
        for (int i = n - 2; i >= 0; i--)
            right[i] = right[i + 1] * arr[i + 1];

        for (int i = 0; i < n; i++)
            result[i] = left[i] * right[i];

        return result;
    }

    static void Main()
    {
        int[] arr = {1, 2, 3, 4};
        Console.WriteLine("Producto excepto índice: " + string.Join(", ", ProductExceptSelf(arr)));
    }
}
