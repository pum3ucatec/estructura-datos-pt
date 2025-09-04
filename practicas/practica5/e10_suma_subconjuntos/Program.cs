using System;
using System.Collections.Generic;

class ejercicio_10 {
    static void Backtrack(int[] arr, int target, int index, List<int> actual) {
        if (target == 0) {
            Console.WriteLine("[" + string.Join(", ", actual) + "]");
            return;
        }
        if (index == arr.Length || target < 0) return;

        actual.Add(arr[index]);
        Backtrack(arr, target - arr[index], index, actual);
        actual.RemoveAt(actual.Count - 1);

        Backtrack(arr, target, index + 1, actual);
    }

    static void Main() {
        Console.WriteLine("Ingrese tamaño del arreglo:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Ingrese los elementos:");
        for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el número target:");
        int target = int.Parse(Console.ReadLine());

        Console.WriteLine("Subconjuntos cuya suma es igual al target:");
        Backtrack(arr, target, 0, new List<int>());
    }
}
