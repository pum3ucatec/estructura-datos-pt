using System;
using System.Linq;

class NumeroFaltante
{
    static void Main()
    {
        int[] arreglo = { 1, 2, 4, 5, 6 };

        int faltante = EncontrarFaltante(arreglo);

        Console.WriteLine("Arreglo: [" + string.Join(", ", arreglo) + "]");
        Console.WriteLine("Número faltante: " + faltante);
    }

    static int EncontrarFaltante(int[] arreglo)
    {
        int n = arreglo.Length + 1; // porque falta un número
        int sumaEsperada = n * (n + 1) / 2; // fórmula suma 1 + 2 + ... + n
        int sumaReal = arreglo.Sum();

        return sumaEsperada - sumaReal;
    }
}

