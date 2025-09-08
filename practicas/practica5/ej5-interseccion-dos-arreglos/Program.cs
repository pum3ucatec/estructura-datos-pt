using System;
class Ejercicio5 {
    static void Main() {
        int[] arreglo1 = {1, 2, 2, 1};
        int[] arreglo2 = {2, 2};
        bool[] usado = new bool[arreglo2.Length];

        Console.Write("Intersección: ");
        for (int i = 0; i < arreglo1.Length; i++) {
            for (int j = 0; j < arreglo2.Length; j++) {
                if (arreglo1[i] == arreglo2[j] && !usado[j]) {
                    Console.Write(arreglo1[i] + " ");
                    usado[j] = true;
                    break;
                }
            }
        }
    }
}
