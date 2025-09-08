// Determinar si un número existe en un arreglo.
using System;

class Program
{

    public static bool BuscarElementoRecursivo(int[] arr, int valor, int index)
    {
        if (arr == null || arr.Length == 0)
            throw new ArgumentException("El arreglo no puede estar vacío.");

        if (index >= arr.Length)
            return false;

        if (arr[index] == valor)
            return true;

        return BuscarElementoRecursivo(arr, valor, index + 1);
    }

    static void Main(string[] args)
    {
        Console.Write("¿Cuántos elementos tendrá el arreglo?: ");
        if (int.TryParse(Console.ReadLine(), out int cantidad) && cantidad > 0)
        {
            int[] arreglo = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out arreglo[i]))
                {
                    Console.Write("Entrada inválida. Ingresa un número entero: ");
                }
            }

            Console.Write("Ingresa el número que deseas buscar: ");
            if (int.TryParse(Console.ReadLine(), out int valorBuscado))
            {
                bool encontrado = BuscarElementoRecursivo(arreglo, valorBuscado, 0);
                Console.WriteLine(encontrado
                    ? $" El número {valorBuscado} SÍ está en el arreglo."
                    : $" El número {valorBuscado} NO está en el arreglo.");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor ingresa un número entero.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor ingresa un número entero positivo.");
        }
    }
}

