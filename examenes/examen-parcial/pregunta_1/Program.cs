using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 1, 2, 3, 5, 6 }; // Falta el 4

        int n = numeros.Length + 1; // El tamaño real debería ser 6
        int sumaTotal = n * (n + 1) / 2;

        int sumaArreglo = 0;
        foreach (int num in numeros)
        {
            sumaArreglo += num;
        }

        int faltante = sumaTotal - sumaArreglo;

        Console.WriteLine($"El número faltante es: {faltante}");
    }
}
