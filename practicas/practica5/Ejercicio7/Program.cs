using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 1, 2, 3, 4 };

        Console.WriteLine("Arreglo original:");
        ImprimirArreglo(numeros);

        int[] resultado = ProductoExceptoIndice(numeros);

        Console.WriteLine("\nArreglo de productos excepto el índice:");
        ImprimirArreglo(resultado);
    }

    // Método para calcular el producto excepto el índice
    static int[] ProductoExceptoIndice(int[] arr)
    {
        int n = arr.Length;
        int[] izquierda = new int[n];
        int[] derecha = new int[n];
        int[] resultado = new int[n];

        // Inicializar acumuladores
        izquierda[0] = 1;
        derecha[n - 1] = 1;

        // Productos desde la izquierda
        for (int i = 1; i < n; i++)
        {
            izquierda[i] = izquierda[i - 1] * arr[i - 1];
        }

        // Productos desde la derecha
        for (int i = n - 2; i >= 0; i--)
        {
            derecha[i] = derecha[i + 1] * arr[i + 1];
        }

        // Multiplicar izquierda y derecha
        for (int i = 0; i < n; i++)
        {
            resultado[i] = izquierda[i] * derecha[i];
        }

        return resultado;
    }

    // Método para imprimir un arreglo
    static void ImprimirArreglo(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
