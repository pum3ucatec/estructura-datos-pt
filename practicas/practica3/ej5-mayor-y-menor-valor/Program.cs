// Ejercicio 5: Encontrar el mayor y menor valor en un arreglo
// Camii
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] nums = { 12, 5, 8, 20, 3, 17, 25, 10 };

        // Usamos funciones de Linq: Max() y Min()
        Console.WriteLine($"El numero mayor es = {nums.Max()}, El numero menor es = {nums.Min()}");
    }
}
