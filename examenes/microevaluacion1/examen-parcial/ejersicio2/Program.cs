using System;

class ejersicio2
{
    static void Main(string[] args)
    {
        int[] arreglo = { 1, 2, 4, 5, 6 };  // Falta el 3
        int n = arreglo.Length + 1; // porque falta un número

        int sumaEsperada = n * (n + 1) / 2;
        int sumaActual = 0;

        foreach (int num in arreglo)
        {
            sumaActual += num;
        }

        int numeroFaltante = sumaEsperada - sumaActual;

        Console.WriteLine("El número que falta es el : " + numeroFaltante);
    }
}
