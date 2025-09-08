using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Eliminar duplicados en un arreglo ORDENADO ===");
        Console.WriteLine("Ejemplo de entrada: 1 1 2 2 3 4 4");
        Console.Write("Ingresa un arreglo ordenado (separado por espacios): ");

        int[] arr = (Console.ReadLine() ?? "")
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

        if (arr.Length == 0)
        {
            Console.WriteLine("No ingresaste datos.");
            return;
        }

        int j = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] != arr[j])
            {
                j++;
                arr[j] = arr[i];
            }
        }

        Console.WriteLine("Sin duplicados: " + string.Join(" ", arr.Take(j + 1)));
    }
}
