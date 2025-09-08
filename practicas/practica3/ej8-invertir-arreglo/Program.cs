using System;
class Ejercicio8
{
    static void Main()
    {
        int[] original = { 1, 2, 3, 4, 5 };
        int[] invertido = new int[original.Length];

        for (int i = 0; i < original.Length; i++)
        {
            invertido[i] = original[original.Length - 1 - i];
        }

        Console.WriteLine("Arreglo invertido:");
        
        for (int i = 0; i < invertido.Length; i++)
        {
            Console.Write(invertido[i] + " ");
        }

    }
}