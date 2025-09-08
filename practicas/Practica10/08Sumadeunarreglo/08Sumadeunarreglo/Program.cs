// Calcular la suma de todos los elementos de un arreglo.
using System;

class Program
{
 
    public static int SumaArregloRecursiva(int[] arr, int index)
    {
        if (arr == null || arr.Length == 0)
            throw new ArgumentException("El arreglo no puede estar vacío.");

        if (index >= arr.Length)
            return 0;

        return arr[index] + SumaArregloRecursiva(arr, index + 1);
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

            Console.WriteLine("Arreglo ingresado: [" + string.Join(", ", arreglo) + "]");
            int suma = SumaArregloRecursiva(arreglo, 0);
            Console.WriteLine($"La suma de los elementos es: {suma}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor ingresa un número entero positivo.");
        }
    }
}
