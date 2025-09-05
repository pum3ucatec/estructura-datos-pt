using System;

class Ejercicio8
{
    public static int SumaArreglo(int[] arr, int n)
    {
        if (n == 0) 
            return 0;
        return arr[n - 1] + SumaArreglo(arr, n - 1);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Suma de Arreglo ===");

        Console.Write("Ingresa la cantidad de elementos: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int resultado = SumaArreglo(arr, n);

        Console.WriteLine($"La suma del arreglo es: {resultado}");
    }
}