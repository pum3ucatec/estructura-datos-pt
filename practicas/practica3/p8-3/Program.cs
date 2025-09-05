using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 1, 2, 3, 4, 5 };
        int[] invertido = new int[numeros.Length];
        for (int i = 0; i < numeros.Length; i++)
        {
            invertido[i] = numeros[numeros.Length - 1 - i];
        }
        Console.WriteLine("Arreglo invertido: " + string.Join(", ", invertido));
    }
}