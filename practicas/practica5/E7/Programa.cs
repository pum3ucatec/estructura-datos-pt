using System;

class ProductoExceptoIndice
{
    static void Main(string[] args)
    {
        int[] numeros = { 1, 2, 3, 4 };

        Console.WriteLine("Arreglo original:");
        ImprimirArreglo(numeros);

        int[] resultado = ProductoExcepto(numeros);

        Console.WriteLine("\nArreglo resultado:");
        ImprimirArreglo(resultado);
    }

    static int[] ProductoExcepto(int[] arr)
    {
        int n = arr.Length;
        int[] left = new int[n];
        int[] right = new int[n];
        int[] resultado = new int[n];

        // Llenar left
        left[0] = 1;
        for (int i = 1; i < n; i++)
        {
            left[i] = left[i - 1] * arr[i - 1];
        }

        // Llenar right
        right[n - 1] = 1;
        for (int i = n - 2; i >= 0; i--)
        {
            right[i] = right[i + 1] * arr[i + 1];
        }

        // Calcular resultado
        for (int i = 0; i < n; i++)
        {
            resultado[i] = left[i] * right[i];
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
