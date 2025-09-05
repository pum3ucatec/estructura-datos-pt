using System;

class Ejercicio8
{
    static void Main()
    {
        int[] arregloOriginal = { 1, 2, 3, 4, 5 };
        int[] arregloInvertido = new int[arregloOriginal.Length];

        for (int i = 0; i < arregloOriginal.Length; i++)
        {
            arregloInvertido[i] = arregloOriginal[arregloOriginal.Length - 1 - i];
        }

        Console.WriteLine("Arreglo invertido:");
        foreach (int n in arregloInvertido)
            Console.Write(n + " ");
    }
}
