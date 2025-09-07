using System;

class ProductoExceptoIndice
{
    static void Main(string[] args)
    {
        int[] numeros = { 1, 2, 3, 4 };

        Console.WriteLine("Arreglo original:");
        ImprimirArreglo(numeros);

        int[] resultado = CalcularProductoExceptoIndice(numeros);

        Console.WriteLine("\nArreglo resultado:");
        ImprimirArreglo(resultado);
    }

    // Calcula el producto de todos los elementos excepto el del índice actual
    static int[] CalcularProductoExceptoIndice(int[] arr)
    {
        int n = arr.Length;
        int[] izquierda = new int[n];
        int[] derecha = new int[n];
        int[] resultado = new int[n];

        // Construir productos acumulados desde la izquierda
        izquierda[0] = 1;
        for (int i = 1; i < n; i++)
        {
            izquierda[i] = izquierda[i - 1] * arr[i - 1];
        }

        // Construir productos acumulados desde la derecha
        derecha[n - 1] = 1;
        for (int i = n - 2; i >= 0; i--)
        {
            derecha[i] = derecha[i + 1] * arr[i + 1];
        }

        // Multiplicar izquierda y derecha para cada índice
        for (int i = 0; i < n; i++)
        {
            resultado[i] = izquierda[i] * derecha[i];
        }

        return resultado;
    }

    // Método para imprimir un arreglo en consola
    static void ImprimirArreglo(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
