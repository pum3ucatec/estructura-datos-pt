using System;
class Ejercicio4 {
    static void Main() {
        int[] arreglo = {1, 2, 4, 5, 6};
        int n = arreglo.Length + 1;
        int suma_esperada = n * (n + 1) / 2;
        int suma_real = 0;

        foreach (int num in arreglo) suma_real += num;

        Console.WriteLine("Número faltante: " + (suma_esperada - suma_real));
    }
}
