// Dado un arreglo de enteros y un número `target`, encuentra todos los subconjuntos 
// cuya suma sea igual al `target`.  
// Ejemplo: `[2, 3, 6, 7], target=7` → subconjuntos `[7]`, `[2, 2, 3]`.

using System;
using System.Collections.Generic;

class Ejercicio10
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Ingrese los números del arreglo separados por espacio:");
        string[] input = Console.ReadLine().Split(' ');
        int[] nums = Array.ConvertAll(input, int.Parse);

        Console.Write("Ingrese el valor del target: ");
        int target = int.Parse(Console.ReadLine());

        List<List<int>> resultados = new List<List<int>>();
        List<int> actual = new List<int>();

        EncontrarSubconjuntos(nums, target, 0, actual, resultados);

        Console.WriteLine($"\nSubconjuntos cuya suma es {target}:");
        if (resultados.Count == 0)
        {
            Console.WriteLine("No existen subconjuntos.");
        }
        else
        {
            foreach (var subconjunto in resultados)
            {
                Console.WriteLine($"[{string.Join(", ", subconjunto)}]");
            }
        }
    }

    static void EncontrarSubconjuntos(int[] nums, int target, int index, List<int> actual, List<List<int>> resultados)
    {
        if (target == 0)
        {
            resultados.Add(new List<int>(actual));
            return;
        }

        if (target < 0 || index >= nums.Length)
        {
            return;
        }

        // es para incluir el elemento actual
        actual.Add(nums[index]);
        EncontrarSubconjuntos(nums, target - nums[index], index + 1, actual, resultados);

        // y esto para excluir ese elemento actual
        actual.RemoveAt(actual.Count - 1);
        EncontrarSubconjuntos(nums, target, index + 1, actual, resultados);
    }
}
