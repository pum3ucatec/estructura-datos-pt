using System;

class ejercicio_7 {
    static void Main() {
        Console.WriteLine("Ingrese el tamaño del arreglo:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Ingrese los elementos:");
        for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());

        int[] izquierda = new int[n];
        int[] derecha = new int[n];
        int[] resultado = new int[n];

        izquierda[0] = 1;
        for (int i = 1; i < n; i++) izquierda[i] = izquierda[i - 1] * arr[i - 1];

        derecha[n - 1] = 1;
        for (int i = n - 2; i >= 0; i--) derecha[i] = derecha[i + 1] * arr[i + 1];

        for (int i = 0; i < n; i++) resultado[i] = izquierda[i] * derecha[i];

        Console.WriteLine("Resultado:");
        Console.WriteLine(string.Join(", ", resultado));
    }
}
