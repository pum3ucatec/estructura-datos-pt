// Ejercicio 4: Calcular el promedio de un arreglo
// Camii
using System;
using System.Linq; // Necesario para usar .Sum()

class Program
{
    static void Main()
    {
        // Arreglo con notas
        int[] notas = { 80, 70, 90, 60, 100 };

        // Calculamos promedio = suma de elementos / cantidad
        double promedio = (double)notas.Sum() / notas.Length;

        Console.WriteLine($"El promedio del numero es = {promedio}");
    }
}

