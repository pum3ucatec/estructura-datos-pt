// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int[] Numeros = { 8, 3, 5, 1, 9 };

        Console.WriteLine("Arreglo desordenado: [" + string.Join(", ", Numeros) + "]");

        for (int i = 0; i < Numeros.Length - 1; i++)
        {
            for (int j = 0; j < Numeros.Length - 1 - i; j++)
            {
                if (Numeros[j] > Numeros[j + 1])
                {
                    int Temp = Numeros[j];
                    Numeros[j] = Numeros[j + 1];
                    Numeros[j + 1] = Temp;
                }
            }
        }

        Console.WriteLine("Arreglo ordenado: [" + string.Join(", ", Numeros) + "]");
    }
}

