// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int[] Arreglo = { 1, 2, 3, 4, 5 };

        int[] Invertido = new int[Arreglo.Length];

        for (int i = 0; i < Arreglo.Length; i++)
        {
            Invertido[i] = Arreglo[Arreglo.Length - 1 - i];
        }

        Console.WriteLine("Arreglo original: [" + string.Join(", ", Arreglo) + "]");
        Console.WriteLine("Arreglo invertido: [" + string.Join(", ", Invertido) + "]");
    }
}

