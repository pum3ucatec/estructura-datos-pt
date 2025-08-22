using System;

class Program
{
    static void Main()
    {
        int[] arreglo = {1, 2, 4, 5, 6};
        int n = 6; // El rango esperado es de 1 a 6

        int faltante = EncontrarNumeroFaltante(arreglo, n);
        Console.WriteLine($"El número que falta es: {faltante}");
    }

    static int EncontrarNumeroFaltante(int[] arreglo, int n)
    {
        int sumaEsperada = n * (n + 1) / 2;
        int sumaArreglo = 0;

        foreach (int num in arreglo)
        {
            sumaArreglo += num;
        }

        return sumaEsperada - sumaArreglo;
    }
}
