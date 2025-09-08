using System;

class Ejercicio1
{
    static void Main()
    {
        int[] arr = {1, 2, 3, 4, 5};
        int k = 2;

        for (int i = 0; i < k; i++)
        {
            int ultimo = arr[arr.Length - 1];
            for (int j = arr.Length - 1; j > 0; j--)
            {
                arr[j] = arr[j - 1];
            }
            arr[0] = ultimo;
        }

        Console.WriteLine("Arreglo rotado:");
        foreach (int n in arr) Console.Write(n + " ");
    }
}
