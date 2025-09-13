using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arreglo = { 1, 2, 3, 4 };
        int n = arreglo.Length;
        int[] resultado = new int[n];

        // Arrays auxiliares para productos a la izquierda y derecha
        int[] izquierda = new int[n];
        int[] derecha = new int[n];

        // Producto de elementos a la izquierda de cada índice
        izquierda[0] = 1;
        for (int i = 1; i < n; i++)
        {
            izquierda[i] = izquierda[i - 1] * arreglo[i - 1];
        }

        // Producto de elementos a la derecha de cada índice
        derecha[n - 1] = 1;
        for (int i = n - 2; i >= 0; i--)
        {
            derecha[i] = derecha[i + 1] * arreglo[i + 1];
        }

        // El resultado en cada posición es el producto de izquierda y derecha
        for (int i = 0; i < n; i++)
        {
            resultado[i] = izquierda[i] * derecha[i];
        }

        Console.WriteLine("Arreglo original: " + string.Join(", ", arreglo));
        Console.WriteLine("Arreglo de productos excepto el índice: " + string.Join(", ", resultado));
    }
}