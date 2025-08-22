// Encontrar el Número que Falta En un arreglo de números del 1 al n, falta un número. Encuentra cuál es.
// Ejemplo: [1, 2, 4, 5, 6] → Falta 3.
// Camiii
using System;

class Pregunta2
{
    static void Main()
    {
        int[] arr = { 1, 2, 4, 5, 6 };
        int n = arr.Length + 1; // porque falta uno

        int sumaEsperada = n * (n + 1) / 2;
        int sumaReal = 0;

        foreach (int num in arr)
            sumaReal += num;

        Console.WriteLine("El número que falta en el arreglo es: " + (sumaEsperada - sumaReal));
    }
}
