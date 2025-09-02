using System;
class Ejercicio7 {
    static void Main() {
        int[] arreglo = {1, 2, 3, 4};
        int n = arreglo.Length;
        int[] izquierda = new int[n];
        int[] derecha = new int[n];
        int[] resultado = new int[n];

        izquierda[0] = 1;
        for (int i = 1; i < n; i++) izquierda[i] = izquierda[i - 1] * arreglo[i - 1];

        derecha[n - 1] = 1;
        for (int i = n - 2; i >= 0; i--) derecha[i] = derecha[i + 1] * arreglo[i + 1];

        for (int i = 0; i < n; i++) resultado[i] = izquierda[i] * derecha[i];

        Console.WriteLine("Resultado: " + string.Join(", ", resultado));
    }
}
