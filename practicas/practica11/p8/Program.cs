using System;

class SumaArregloRecursiva
{
    static int SumaArreglo(int[] arr, int n)
    {
        if (n <= 0) return 0;
        return arr[n - 1] + SumaArreglo(arr, n - 1);
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
        Console.WriteLine($"La suma del arreglo es: {SumaArreglo(arr, len)}");
    }
}
