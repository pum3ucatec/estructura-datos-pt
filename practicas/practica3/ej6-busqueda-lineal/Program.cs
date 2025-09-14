// Ejercicio 6: Buscar un número dentro de un arreglo
// Camii
using System;

class Program
{
    static void Main()
    {
        int[] buscarArr = { 5, 8, 12, 17, 20, 25, 30, 35, 40, 45 };

        Console.Write("Ingrese un número: ");
        int buscar = int.Parse(Console.ReadLine()!);

        // Buscamos la posición con Array.IndexOf
        int pos = Array.IndexOf(buscarArr, buscar);

        if (pos != -1)
            Console.WriteLine($"El número {buscar} está en la posición {pos}");
        else
            Console.WriteLine("Número no encontrado");
    }
}

