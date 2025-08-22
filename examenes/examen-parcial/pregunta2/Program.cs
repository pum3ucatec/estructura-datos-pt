//Encontrar el Número que Falta En un arreglo de números del 1 al n, falta un número.
// Encuentra cuál es. Ejemplo: [1, 2, 4, 5, 6] → Falta 3.

using System;

class Pregunta2 {
    static void Main() {
        Console.Write("Ingrese la cantidad de números en el arreglo: ");
        int cantidad = int.Parse(Console.ReadLine());

        int[] numeros = new int[cantidad];
        
        Console.WriteLine("Ingrese los números (secuencia del 1 al N con uno faltante):");
        for (int i = 0; i < cantidad; i++) {
            Console.Write($"Número {i+1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int n = cantidad + 1; // porque falta uno
        int sumaEsperada = n * (n + 1) / 2;
        int sumaActual = 0;

        foreach (int num in numeros) {
            sumaActual += num;
        }

        int faltante = sumaEsperada - sumaActual;
        Console.WriteLine("\nNúmero faltante: " + faltante);
    }
}
