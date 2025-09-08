// Ejercicio 7: Contar cuántas veces aparece un número en un arreglo
// Camii
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] ocurrencias = { 2, 5, 2, 8, 2, 9 };

        Console.Write("Que numero desea buscar: ");
        int buscado = int.Parse(Console.ReadLine()!);

        // Contamos cuántas veces aparece el número
        int conteo = ocurrencias.Count(x => x == buscado);

        Console.WriteLine($"El número solicitado {buscado} aparece {conteo} veces");
    }
}

