using System;
using System.Collections.Generic;

class Ejercicio10
{
    static void Main()
    {
        Console.WriteLine("Ejemplo con target = 7:");
        int[] ejemplo = { 2, 3, 6, 7 };
        EncontrarSubconjuntos(ejemplo, 7);

        Console.WriteLine("\nAhora ingresa tu arreglo (separado por espacios):");
        string[] input = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();
        int[] arr = Array.ConvertAll(input, int.Parse);

        Console.WriteLine("Ingresa el target:");
        int target = int.Parse(Console.ReadLine() ?? "0");

        EncontrarSubconjuntos(arr, target);
    }

    static void EncontrarSubconjuntos(int[] arr, int target)
    {
        List<int> actual = new List<int>();
        HashSet<string> vistos = new HashSet<string>();
        Backtrack(arr, target, 0, actual, vistos);
    }

    static void Backtrack(int[] arr, int target, int inicio, List<int> actual, HashSet<string> vistos)
    {
        if (target == 0)
        {
            string clave = string.Join(",", actual);
            if (!vistos.Contains(clave))
            {
                Console.WriteLine("[" + string.Join(", ", actual) + "]");
                vistos.Add(clave);
            }
            return;
        }

        for (int i = inicio; i < arr.Length; i++)
        {
            if (arr[i] <= target)
            {
                actual.Add(arr[i]);
                Backtrack(arr, target - arr[i], i + 1, actual, vistos);
                actual.RemoveAt(actual.Count - 1);
            }
        }
    }
}
