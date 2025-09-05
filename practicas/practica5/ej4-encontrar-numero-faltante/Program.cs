using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 4, 5, 6 };
        Console.WriteLine("Número faltante: " + Encontrar(arr, 6));
    }
    static int Encontrar(int[] arr, int n)
    {
        int suma = n * (n + 1) / 2;
        int sumaActual = 0;
        foreach (int num in arr) sumaActual += num;
        return suma - sumaActual;
    }


}