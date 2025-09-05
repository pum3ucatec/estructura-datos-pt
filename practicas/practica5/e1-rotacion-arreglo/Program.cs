using System;

class RotacionArreglo
{
    public static void RotarDerecha(int[] arr, int k)
    {
        if (arr == null || arr.Length == 0) return;
        
        k = k % arr.Length;
        if (k == 0) return;
        
        Reverse(arr, 0, arr.Length - 1);
        Reverse(arr, 0, k - 1);
        Reverse(arr, k, arr.Length - 1);
    }

    private static void Reverse(int[] arr, int start, int end)
    {
        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
    }

    public static void Main()
    {
        int[] arr = {1, 2, 3, 4, 5};
        Console.WriteLine("Arreglo original: " + string.Join(", ", arr));
        
        RotarDerecha(arr, 2);
        Console.WriteLine("Rotado 2 posiciones: " + string.Join(", ", arr));
    }
}