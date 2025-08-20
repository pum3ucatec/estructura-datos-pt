// See https://aka.ms/new-console-template for more information
// Crea Crea un arreglo de 10 números enteros y muéstralos en consola utilizando un ciclo `for`.
using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("Elemento en posición " + i + ": " + numeros[i]);
        }
    }
}

