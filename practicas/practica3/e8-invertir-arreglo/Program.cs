// Dado un arreglo, crea un segundo arreglo que contenga los mismos elementos pero en orden inverso.
using System;

class Ejercicio8
{
    static void Main()
    {
        int[] numeros = { 5, 6, 7, 8, 9 };

        int[] inverso = new int[numeros.Length];

        for (int i = 0; i < numeros.Length; i++)
        {
            inverso[i] = numeros[numeros.Length - 1 - i];
        }

        Console.WriteLine("Arreglo original:");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\nArreglo inverso:");
        foreach (int num in inverso)
        {
            Console.Write(num + " ");
        }

    }
}