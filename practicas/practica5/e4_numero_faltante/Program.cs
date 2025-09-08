/* En un arreglo de números del 1 al n, falta un número. Encuentra cuál es.
Ejemplo: [1, 2, 4, 5, 6] → Falta 3. */

using System;

class NumeroFaltante {
    static void Main() {
        Console.WriteLine("Ingrese n:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n - 1];

        Console.WriteLine($"Ingrese {n-1} números del 1 al {n}, con uno faltante:");
        for (int i = 0; i < n - 1; i++) {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int sumaEsperada = n * (n + 1) / 2;
        int sumaReal = 0;
        foreach (int num in arr) sumaReal += num;

        Console.WriteLine("El número faltante es: " + (sumaEsperada - sumaReal));
    }
}
