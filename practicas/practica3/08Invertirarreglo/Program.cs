//Dado un arreglo, crea un segundo arreglo que contenga los mismos elementos pero en orden inverso.  
using System;

class Program
{
    static void Main()
    {
        int[] original = { 1, 2, 3, 4, 5 };

        int[] inverso = new int[original.Length];

        for (int i = 0; i < original.Length; i++)
        {
            inverso[i] = original[original.Length - 1 - i];
        }

        Console.WriteLine("Arreglo en orden inverso:");
        for (int i = 0; i < inverso.Length; i++)
        {
            Console.WriteLine($"Elemento #{i}: {inverso[i]}");
        }
    }
}
