using System;

class BuscarElementoRecursivo
{
    static bool BuscarElemento(int[] arr, int n, int valor)
    {
        if (n <= 0) return false;
        if (arr[n - 1] == valor) return true;
        return BuscarElemento(arr, n - 1, valor);
    }

    static void Main()
    {
        Console.Write("Ingrese la cantidad de elementos: ");
        int len = int.Parse(Console.ReadLine()!);
        int[] arr = new int[len];
        for (int i = 0; i < len; i++)
        {
            Console.Write($"Ingrese el elemento {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine()!);
        }
        Console.Write("Ingrese el número a buscar: ");
        int val = int.Parse(Console.ReadLine()!);
        Console.WriteLine(BuscarElemento(arr, len, val) ? "Número encontrado en el arreglo" : "Número no encontrado");
    }
}
