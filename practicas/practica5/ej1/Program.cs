using System;

class Program
{
    static int[] RotateArray(int[] arr, int k)
    {
        int n = arr.Length;
        k %= n; // evitar rotaciones mayores que n
        int[] result = new int[n];
        for (int i = 0; i < n; i++)
        {
            result[(i + k) % n] = arr[i];
        }
        return result;
    }

    static void Main()
    {
        int[] arr = {1, 2, 3, 4, 5};
        int[] rotated = RotateArray(arr, 2);
        Console.WriteLine("Rotado: " + string.Join(", ", rotated));
    }
}
