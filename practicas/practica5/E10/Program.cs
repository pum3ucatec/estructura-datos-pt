using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] arr = { 2, 3, 6, 7 };

        Console.WriteLine("Arreglo: " + string.Join(", ", arr));

        // Leer el target desde teclado
        Console.Write("Ingrese el número target: ");
        int target = int.Parse(Console.ReadLine());

        List<int> subset = new List<int>();
        Console.WriteLine($"Subconjuntos cuya suma es {target}:");
        EncontrarSubconjuntos(arr, 0, subset, 0, target);
    }

    static void EncontrarSubconjuntos(int[] arr, int index, List<int> subset, int sumaActual, int target)
    {
        if (sumaActual == target)
        {
            Console.WriteLine("[" + string.Join(", ", subset) + "]");
            return; // Encontramos un subconjunto válido
        }

        if (sumaActual > target || index >= arr.Length)
            return; // No es válido, cortamos búsqueda

        // Incluir el elemento actual
        subset.Add(arr[index]);
        EncontrarSubconjuntos(arr, index + 1, subset, sumaActual + arr[index], target);

        // Excluir el elemento actual
        subset.RemoveAt(subset.Count - 1);
        EncontrarSubconjuntos(arr, index + 1, subset, sumaActual, target);
    }
}
