using System;

class ejercicio_5 {
    static void Main() {
        Console.WriteLine("Ingrese tamaño del primer arreglo:");
        int n1 = int.Parse(Console.ReadLine());
        int[] arr1 = new int[n1];
        Console.WriteLine("Ingrese los elementos:");
        for (int i = 0; i < n1; i++) arr1[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese tamaño del segundo arreglo:");
        int n2 = int.Parse(Console.ReadLine());
        int[] arr2 = new int[n2];
        Console.WriteLine("Ingrese los elementos:");
        for (int i = 0; i < n2; i++) arr2[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("Intersección:");
        for (int i = 0; i < n1; i++) {
            for (int j = 0; j < n2; j++) {
                if (arr1[i] == arr2[j]) {
                    Console.Write(arr1[i] + " ");
                    arr2[j] = int.MinValue; // Evita duplicados
                    break;
                }
            }
        }
    }
}
