using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int k = 2;

        RotateArray(arr, k);

        Console.WriteLine("Arreglo rotado: " + string.Join(", ", arr));
    }

    static void RotateArray(int[] arr, int k)
    {
        int n = arr.Length;
        k = k % n; // en caso de que k > n

        // Paso 1: invertir todo el arreglo
        Reverse(arr, 0, n - 1);

        // Paso 2: invertir los primeros k elementos
        Reverse(arr, 0, k - 1);

        // Paso 3: invertir los últimos n-k elementos
        Reverse(arr, k, n - 1);
    }

    static void Reverse(int[] arr, int left, int right)
    {
        while (left < right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
            left++;
            right--;
        }
    }
}

