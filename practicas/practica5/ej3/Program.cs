using System;

class Program
{
    static int[] RemoveDuplicates(int[] arr)
    {
        if (arr.Length == 0) return arr;
        int j = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] != arr[j])
            {
                j++;
                arr[j] = arr[i];
            }
        }
        int[] result = new int[j + 1];
        Array.Copy(arr, result, j + 1);
        return result;
    }

    static void Main()
    {
        int[] arr = {1, 1, 2, 2, 3, 4, 4};
        Console.WriteLine("Sin duplicados: " + string.Join(", ", RemoveDuplicates(arr)));
    }
}
