/* 8. Invertir arreglo
Dado un arreglo, crea un segundo arreglo que contenga los mismos elementos pero en orden inverso.*/

using System;

class ejercicio_8
{
    static void Main()
    {
        int[] original = { 1, 2, 3, 4, 5 };
        int[] invertido = new int[original.Length];

        for (int i = 0; i < original.Length; i++)
        {
            invertido[i] = original[original.Length - 1 - i];
        }

        Console.WriteLine($"Arreglo original:  [{string.Join(", ", original)}]");
        Console.WriteLine($"Arreglo invertido: [{string.Join(", ", invertido)}]");
    }
}
