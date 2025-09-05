using System;

class ejercicio_8
{
    public static int suma_arreglo(int[] arr, int n)
    {
        if (n == 0) 
            return 0;
        return arr[n - 1] + suma_arreglo(arr, n - 1);
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

        int resultado = suma_arreglo(arr, n);

        Console.WriteLine($"La suma del arreglo es: {resultado}");
    }
}