using System;
class Ejercicio1 {
    static void Main() {
        int[] arreglo = {1, 2, 3, 4, 5};
        int k = 2;
        int n = arreglo.Length;
        int[] resultado = new int[n];

        for (int i = 0; i < n; i++) {
            resultado[(i + k) % n] = arreglo[i];
        }

        Console.WriteLine("Arreglo rotado: " + string.Join(", ", resultado));
    }
}
