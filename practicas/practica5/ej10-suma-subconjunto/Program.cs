using System;
using System.Collections.Generic;

Console.WriteLine("Ejercicio 10! Suma de Subconjuntos (Backtracking)");


int[] arr = { 1, 2, 4, 5 };
int target = 6;

Console.WriteLine("Arreglo: " + string.Join(", ", arr));
Console.WriteLine("Target: " + target);

void BuscarSubconjuntos(int[] arr, int index, List<int> subset, int suma)
{
    if (suma == target)
    {
        Console.WriteLine("[" + string.Join(", ", subset) + "]");
        return;
    }

    if (suma > target || index >= arr.Length)
        return;


    subset.Add(arr[index]);
    BuscarSubconjuntos(arr, index + 1, subset, suma + arr[index]);
    subset.RemoveAt(subset.Count - 1);


    BuscarSubconjuntos(arr, index + 1, subset, suma);
}


BuscarSubconjuntos(arr, 0, new List<int>(), 0);
