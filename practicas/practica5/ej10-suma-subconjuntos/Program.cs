using System;
using System.Collections.Generic;
class Ejercicio10 {
    static void BuscarSubconjuntos(int[] arreglo, int target, int index, List<int> actual) {
        if (target == 0) {
            Console.WriteLine("[" + string.Join(", ", actual) + "]");
            return;
        }
        if (target < 0 || index == arreglo.Length) return;
        actual.Add(arreglo[index]);
        BuscarSubconjuntos(arreglo, target - arreglo[index], index + 1, actual);
        actual.RemoveAt(actual.Count - 1);
        BuscarSubconjuntos(arreglo, target, index + 1, actual);
    }

    static void Main() {
        int[] arreglo = {2, 3, 6, 7};
        int target = 7;
        Console.WriteLine("Subconjuntos con suma " + target + ":");
        BuscarSubconjuntos(arreglo, target, 0, new List<int>());
    }
}
