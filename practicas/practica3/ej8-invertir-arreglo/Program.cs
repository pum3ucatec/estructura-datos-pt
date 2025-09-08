// Ejercicio 8: Invertir un arreglo
// Camii
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] original = { 1, 2, 3, 4, 5 };

        // Usamos Reverse() y lo convertimos a un arreglo
        int[] invertido = original.Reverse().ToArray();

        Console.WriteLine(" El arreglo invertido es de esta manera: " + string.Join(", ", invertido));
        Console.WriteLine(" El arreglo original es de esta manera: " + string.Join(", ", original));
    }
}
