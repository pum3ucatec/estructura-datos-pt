using System;
class Ejercicio3 {
    static void Main() {
        int[] arreglo = {1, 1, 2, 2, 3, 4, 4};
        int j = 0;

        for (int i = 1; i < arreglo.Length; i++) {
            if (arreglo[i] != arreglo[j]) {
                j++;
                arreglo[j] = arreglo[i];
            }
        }

        Console.Write("Arreglo sin duplicados: ");
        for (int i = 0; i <= j; i++) Console.Write(arreglo[i] + " ");
    }
}
