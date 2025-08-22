using System;

class Program
{
    static void Main()
    {
        // Ejemplo diferente: arreglo ordenado con duplicados
        int[] arr = { 0, 0, 1, 1, 1, 2, 3, 3, 4, 4, 5 };
        int n = arr.Length;

        Console.WriteLine("Arreglo original: " + string.Join(", ", arr));

        int newLength = RemoveDuplicates(arr, n);

        Console.Write("Arreglo sin duplicados: ");
        for (int i = 0; i < newLength; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    static int RemoveDuplicates(int[] arr, int n)
    {
        if (n == 0 || n == 1)
            return n;

        // índice para el "nuevo arreglo" sin duplicados
        int j = 0;

        // recorrer el arreglo y comparar con el siguiente
        for (int i = 0; i < n - 1; i++)
        {
            if (arr[i] != arr[i + 1])
            {
                arr[j++] = arr[i];
            }
        }

        // último elemento siempre se conserva
        arr[j++] = arr[n - 1];

        return j; // nueva longitud del arreglo
    }
}
