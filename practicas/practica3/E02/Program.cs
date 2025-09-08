using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = i + 1;
        }
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}