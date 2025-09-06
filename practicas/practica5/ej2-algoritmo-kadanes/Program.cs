using System;
class Ejercicio2 {
    static void Main() {
        int[] arreglo = {-2, 1, -3, 4, -1, 2, 1, -5, 4};
        int max_actual = arreglo[0], max_total = arreglo[0];

        for (int i = 1; i < arreglo.Length; i++) {
            max_actual = Math.Max(arreglo[i], max_actual + arreglo[i]);
            max_total = Math.Max(max_total, max_actual);
        }

        Console.WriteLine("Suma máxima: " + max_total);
    }
}
