// En un arreglo de números del `1` al `n`, falta un número. Encuentra cuál es. 
using System;

class Programa
{
    static void Main()
    {
        int[] arreglo = { 1, 2, 4, 5, 6 }; 
        int n = 6; 

        int faltante = EncontrarFaltante(arreglo, n);

        Console.WriteLine("El número faltante es: " + faltante);
    }

    static int EncontrarFaltante(int[] arreglo, int n)
    {
        int sumaEsperada = n * (n + 1) / 2;
        int sumaReal = 0;

        foreach (int num in arreglo)
        {
            sumaReal += num;
        }

        return sumaEsperada - sumaReal;
    }
}
