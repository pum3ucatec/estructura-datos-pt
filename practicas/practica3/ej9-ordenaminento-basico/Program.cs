// Ejercicio 9: Ordenar un arreglo con método burbuja
// Camii
using System;

class Program
{
    static void Main()
    {
        int[] desordenado = { 8, 3, 5, 1, 9 };

        // Método burbuja
        for (int i = 0; i < desordenado.Length - 1; i++)
        {
            for (int j = 0; j < desordenado.Length - i - 1; j++)
            {
                if (desordenado[j] > desordenado[j + 1])
                {
                    // Intercambiamos valores
                    int temp = desordenado[j];
                    desordenado[j] = desordenado[j + 1];
                    desordenado[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Arreglo ordenado: " + string.Join(", ", desordenado));
    }
}

