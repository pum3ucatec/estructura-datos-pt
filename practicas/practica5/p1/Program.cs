using System;

class Program
{
    static void Main()
    {
        int[] arr = {1, 2, 3, 4, 5};
        int k = 2;

        Console.WriteLine("Arreglo original: " + string.Join(", ", arr));

        RotateArray(arr, k);

        Console.WriteLine("Arreglo rotado: " + string.Join(", ", arr));
    }

    static void RotateArray(int[] array, int k)
    {
        int n = array.Length;
        k = k % n; // Para no rotar más de la longitud
        Reverse(array, 0, n - 1);
        Reverse(array, 0, k - 1);
        Reverse(array, k, n - 1);
    }

    static void Reverse(int[] array, int start, int end)
    {
        while (start < end)
        {
            int temp = array[start];
            array[start] = array[end];
            array[end] = temp;
            start++;
            end--;
        }
    }
}
