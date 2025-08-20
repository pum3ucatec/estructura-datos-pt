// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 5, 10, 15, 20, 25 };
        
        int suma = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            suma += numeros[i];
        }

        Console.WriteLine("La suma de todos los elementos es: " + suma);
    }
}

