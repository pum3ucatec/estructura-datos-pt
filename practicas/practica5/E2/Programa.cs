using System;

class SubarregloMaximo
{
    static void Main(string[] args)
    {
        int[] Numeros = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

        Console.WriteLine("Arreglo original:");
        foreach (int Num in Numeros)
        {
            Console.Write(Num + " ");
        }
        Console.WriteLine();

        int SumaMaxima = Kadane(Numeros);

        Console.WriteLine("\nLa suma máxima de un subarreglo es: " + SumaMaxima);
    }

    static int Kadane(int[] Arreglo)
    {
        int MaxActual = Arreglo[0];
        int MaxGlobal = Arreglo[0];

        for (int i = 1; i < Arreglo.Length; i++)
        {
            MaxActual = Math.Max(Arreglo[i], MaxActual + Arreglo[i]);

            if (MaxActual > MaxGlobal)
            {
                MaxGlobal = MaxActual;
            }
        }

        return MaxGlobal;
    }
}
