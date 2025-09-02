using System;

class Ejercicio7
{
    static void Main()
    {
        Console.WriteLine("Ejemplo:");
        int[] ejemplo = { 1, 2, 3, 4 };
        MostrarProductos(ejemplo);

        Console.WriteLine("\nAhora ingresa tu arreglo (separado por espacios):");
        string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] arr = Array.ConvertAll(input, int.Parse);
        MostrarProductos(arr);
    }

    static void MostrarProductos(int[] arr)
    {
        int n = arr.Length;
        int[] resultado = new int[n];

        int[] izquierda = new int[n];
        int[] derecha = new int[n];

        izquierda[0] = 1;
        for (int i = 1; i < n; i++)
            izquierda[i] = izquierda[i - 1] * arr[i - 1];

        derecha[n - 1] = 1;
        for (int i = n - 2; i >= 0; i--)
            derecha[i] = derecha[i + 1] * arr[i + 1];

        for (int i = 0; i < n; i++)
            resultado[i] = izquierda[i] * derecha[i];

        Console.WriteLine("Arreglo: [" + string.Join(", ", arr) + "]");
        Console.WriteLine("Resultado: [" + string.Join(", ", resultado) + "]");
    }
}