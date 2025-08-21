// Implementa un algoritmo sencillo (por ejemplo, **Burbuja**) para ordenar un arreglo de enteros de menor a mayor.

using System;
class Ejercicio9
{
    static void Main()
    {
        int[] numeros = { 8, 3, 5, 1, 9 };

        Console.WriteLine("Arreglo desordenado:");
        MostrarArreglo(numeros);

        // Algoritmo de burbuja
        for (int i = 0; i < numeros.Length - 1; i++) // Recorre todas las posiciones
        {
            for (int j = 0; j < numeros.Length - 1 - i; j++) // Recorre los elementos adyacentes
            {
                if (numeros[j] > numeros[j + 1]) // Si el actual es mayor que el siguiente, se intercambian
                {
                    int temp = numeros[j];
                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\nArreglo ordenado:");
        MostrarArreglo(numeros);
    }

    // Método para imprimir el arreglo
    static void MostrarArreglo(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}