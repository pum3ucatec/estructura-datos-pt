using System;

class Program
{
    static void SubarregloSumaMaxima(int[] arr)
    {
        int maxActual = arr[0];
        int maxTotal = arr[0];
        int inicio = 0, fin = 0, tempInicio = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > maxActual + arr[i])
            {
                maxActual = arr[i];
                tempInicio = i;
            }
            else
            {
                maxActual += arr[i];
            }

            if (maxActual > maxTotal)
            {
                maxTotal = maxActual;
                inicio = tempInicio;
                fin = i;
            }
        }

        Console.Write("Subarreglo con suma máxima: [");
        for (int i = inicio; i <= fin; i++)
        {
            Console.Write(arr[i]);
            if (i < fin) Console.Write(", ");
        }
        Console.WriteLine("]");
        Console.WriteLine("Suma máxima: " + maxTotal);
    }

    static void Main()
    {
        Console.Write("Ingrese los elementos del arreglo separados por espacio: ");
        string[] entrada = Console.ReadLine().Split();
        int[] arreglo = Array.ConvertAll(entrada, int.Parse);

        SubarregloSumaMaxima(arreglo);
    }
}
