// Declarar un arreglo de 10 enteros y cargarlo con valores aleatorios entre 1 y 100.

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[10];
        Random rand = new Random();

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = rand.Next(1, 101);
        }

        // Imprimir los valores del arreglo
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }
    }
}
