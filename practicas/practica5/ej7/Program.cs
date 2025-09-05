using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4 };

        Console.WriteLine("Arreglo original:");
        ImprimirArreglo(arr);

        int[] resultado = ProductoExceptoIndice(arr);

        Console.WriteLine("\nArreglo de productos excepto el índice:");
        ImprimirArreglo(resultado);
    }

    static int[] ProductoExceptoIndice(int[] arr)
    {
        int n = arr.Length;
        int[] resultado = new int[n];

        int[] izquierda = new int[n];
        int[] derecha = new int[n];

        // Productos hacia la izquierda
        izquierda[0] = 1;
        for (int i = 1; i < n; i++)
        {
            izquierda[i] = izquierda[i - 1] * arr[i - 1];
        }

        // Productos hacia la derecha
        derecha[n - 1] = 1;
        for (int i = n - 2; i >= 0; i--)
        {
            derecha[i] = derecha[i + 1] * arr[i + 1];
        }

        // Multiplicamos izquierda * derecha
        for (int i = 0; i < n; i++)
        {
            resultado[i] = izquierda[i] * derecha[i];
        }

        return resultado;
    }

    static void ImprimirArreglo(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
