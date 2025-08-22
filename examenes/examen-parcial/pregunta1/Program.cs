// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 4, 5, 6 };
        int n = 6; // El valor máximo esperado

        int sumaEsperada = n * (n + 1) / 2;
        int sumaReal = 0;

        foreach (int num in arr)
        {
            sumaReal += num;
        }

        int faltante = sumaEsperada - sumaReal;
        Console.WriteLine($"Falta el número: {faltante}");
    }
}

