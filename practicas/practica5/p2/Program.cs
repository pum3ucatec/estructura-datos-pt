using System;

class Program
{
    static void Main()
    {
        int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

        int maxSum = Kadane(arr);

        Console.WriteLine("El subarreglo con suma máxima tiene: " + maxSum);
    }

    static int Kadane(int[] array)
    {
        int maxSoFar = array[0];  // Guarda la suma máxima encontrada
        int maxEndingHere = array[0]; // Suma máxima hasta el índice actual

        for (int i = 1; i < array.Length; i++)
        {
            // Decidimos si empezamos un nuevo subarreglo o seguimos sumando
            maxEndingHere = Math.Max(array[i], maxEndingHere + array[i]);

            // Guardamos el máximo global
            maxSoFar = Math.Max(maxSoFar, maxEndingHere);
        }

        return maxSoFar;
    }
}
