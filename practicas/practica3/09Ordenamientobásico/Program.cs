//Implementa un algoritmo sencillo (por ejemplo, **Burbuja**) para ordenar un arreglo de enteros de menor a mayor.  
using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 8, 3, 5, 1, 9 };

        Console.WriteLine("Arreglo original:");
        MostrarArreglo(numeros);

        for (int i = 0; i < numeros.Length - 1; i++)
        {
            for (int j = 0; j < numeros.Length - 1 - i; j++)
            {
                if (numeros[j] > numeros[j + 1])
                {
                    int temp = numeros[j];
                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\nArreglo ordenado de menor a mayor:");
        MostrarArreglo(numeros);
    }

    static void MostrarArreglo(int[] arreglo)
    {
        for (int i = 0; i < arreglo.Length; i++)
        {
            Console.Write(arreglo[i] + " ");
        }
        Console.WriteLine();
    }
}
