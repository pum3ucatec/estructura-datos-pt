// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        
        int[] arreglo = { 1, 2, 3, 4, 5 };

        int[] invertido = new int[arreglo.Length];

        for (int i = 0; i < arreglo.Length; i++)
        {
            invertido[i] = arreglo[arreglo.Length - 1 - i];
        }

        Console.WriteLine("Arreglo original: [" + string.Join(", ", arreglo) + "]");
        Console.WriteLine("Arreglo invertido: [" + string.Join(", ", invertido) + "]");
    }
}

