using System;

class Programa
{
    static void Main(string[] args)
    {
        int[] numeros = { 1, 2, 4, 5, 6 };

        int faltante = EncontrarFaltante(numeros);

        Console.WriteLine("El número que falta es: " + faltante);
    }

    static int EncontrarFaltante(int[] arreglo)
    {
        int n = arreglo.Length + 1; 
        int sumaEsperada = n * (n + 1) / 2;

        int sumaActual = 0;
        foreach (int num in arreglo)
        {
            sumaActual += num;
        }

        return sumaEsperada - sumaActual;
    }
}