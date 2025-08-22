using System;

class Program
{
    static int EncontrarNumeroFaltante(int[] arreglo, int n)
    {
        // Suma total de los números del 1 al n
        int sumaTotal = n * (n + 1) / 2;

        // Suma de los elementos del arreglo
        int sumaArreglo = 0;
        foreach (int num in arreglo)
        {
            sumaArreglo += num;
        }

        // El número faltante es la diferencia
        return sumaTotal - sumaArreglo;
    }

    static void Main()
    {
        int[] arreglo = { 1, 2, 4, 5, 6 };
        int n = 6;

        int faltante = EncontrarNumeroFaltante(arreglo, n);
        Console.WriteLine($"El número que falta es: {faltante}");
    }
}

