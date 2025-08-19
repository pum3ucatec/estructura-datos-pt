using System;

class Programa2
{
    static void Main(string[] args)
    {
        int[] numeros = { 1,2,3,4,5,6,7,8,9,10 };

        Console.WriteLine("Números del arreglo:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}
