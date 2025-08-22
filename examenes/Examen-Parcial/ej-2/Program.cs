using System;
using System.Collections.Generic;

class Program
{
    static int NumeroFaltante(List<int> arr, int n)
    {
        int sumaEsperada = n * (n + 1) / 2;
        int sumaActual = 0;
        foreach (int num in arr)
            sumaActual += num;
        return sumaEsperada - sumaActual;
    }

    static void Main()
    {
        List<int> arr = new List<int> { 1, 2, 4, 5, 6 };
        int n = 6; // El rango que se instó consta de 6 numeros
        Console.WriteLine("Número faltante: " + NumeroFaltante(arr, n));
    }
}
