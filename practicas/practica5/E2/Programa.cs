using System;

class SubarregloMaximo
{
    static void Main(string[] args)
    {
        // Ejemplo de arreglo
        int[] numeros = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

        Console.WriteLine("Arreglo original:");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Llamamos a Kadane
        int sumaMaxima = Kadane(numeros);

        Console.WriteLine("\nLa suma máxima de un subarreglo es: " + sumaMaxima);
    }

    // Implementación de Kadane
    static int Kadane(int[] arr)
    {
        int maxActual = arr[0];
        int maxGlobal = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            // Elegimos entre empezar nuevo subarreglo o seguir sumando
            maxActual = Math.Max(arr[i], maxActual + arr[i]);

            if (maxActual > maxGlobal)
            {
                maxGlobal = maxActual;
            }
        }

        return maxGlobal;
    }
}
