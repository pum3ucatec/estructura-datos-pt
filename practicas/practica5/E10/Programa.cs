using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 2, 3, 6, 7 };
        int target = 7;

        Console.WriteLine($"Subconjuntos cuya suma es {target}:");
        List<int> actual = new List<int>();
        EncontrarSubconjuntos(numeros, target, 0, actual);
    }

    static void EncontrarSubconjuntos(int[] nums, int target, int indice, List<int> actual)
    {
        if (target == 0)
        {
            Console.WriteLine("[" + string.Join(", ", actual) + "]");
            return;
        }

        if (target < 0 || indice >= nums.Length)
            return;

        // Incluir el número en el subconjunto
        actual.Add(nums[indice]);
        EncontrarSubconjuntos(nums, target - nums[indice], indice, actual); // no avanzamos índice porque se puede repetir

        // Excluir el número
        actual.RemoveAt(actual.Count - 1);
        EncontrarSubconjuntos(nums, target, indice + 1, actual);
    }
}
