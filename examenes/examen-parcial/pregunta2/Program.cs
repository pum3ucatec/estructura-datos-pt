using System;

class pregunta2 {
    static void Main() {
        int[] arr = {1, 2, 4, 5, 6};
        int n = arr.Length + 1;
        int sumaEsperada = n * (n + 1) / 2;
        int sumaReal = 0;

        foreach (int num in arr) sumaReal += num;

        Console.WriteLine("Número faltante: " + (sumaEsperada - sumaReal));
    }
}
