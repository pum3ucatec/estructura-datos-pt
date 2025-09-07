// 8. Suma de un arreglo
// Pregunta:
// Calcular la suma de todos los elementos de un arreglo.
// cami
using System;

class Ejercicio8
{
    public static int SumaArregloRecursiva(int[] arr, int index)
    {
        if (index == arr.Length)
            return 0;
        return arr[index] + SumaArregloRecursiva(arr, index + 1);
    }

    static void Main()
    {
        Console.Write("Ingrese el tamaño del arreglo: ");
        int n = int.Parse(Console.ReadLine());

        int[] arreglo = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            arreglo[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"La suma del arreglo es: {SumaArregloRecursiva(arreglo, 0)}");
    }
}
