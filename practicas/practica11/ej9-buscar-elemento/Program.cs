// 9. Buscar un elemento en un arreglo
// Pregunta:
// Determinar si un número existe en un arreglo.


// Cami
using System;

class Ejercicio9
{
    public static bool BuscarElementoRecursivo(int[] arr, int index, int valor)
    {
        if (index == arr.Length)
            return false;
        if (arr[index] == valor)
            return true;
        return BuscarElementoRecursivo(arr, index + 1, valor);
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

        Console.Write("Ingrese el valor a buscar: ");
        int valor = int.Parse(Console.ReadLine());

        bool existe = BuscarElementoRecursivo(arreglo, 0, valor);
        Console.WriteLine(existe ? "El valor existe en el arreglo." : "El valor no existe en el arreglo.");
    }
}

