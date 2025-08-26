using System;

class EncontrarNumeroFaltante
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 4, 5, 6 };  // Ejemplo
        int n = arr.Length + 1; // porque falta un número

        int numeroFaltante = EncontrarFaltante(arr, n);

        Console.WriteLine($"El número faltante es: {numeroFaltante}");
    }

    static int EncontrarFaltante(int[] arr, int n)
    {
        int sumaEsperada = n * (n + 1) / 2;
        int sumaActual = 0;

        foreach (int num in arr)
        {
            sumaActual += num;
        }

        return sumaEsperada - sumaActual;
    }
}
