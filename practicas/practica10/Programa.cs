using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Ingrese la cantidad de elementos del arreglo: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Por favor ingrese un número entero positivo: ");
        }

        int[] numeros = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Ingrese el valor para la posición {i}: ");
            while (!int.TryParse(Console.ReadLine(), out numeros[i]))
            {
                Console.Write($"Entrada inválida. Ingrese un número entero para la posición {i}: ");
            }
        }

        Console.WriteLine("Los números ingresados son: " + string.Join(", ", numeros));

        int resultado = SumaArregloRecursiva(numeros);
        Console.WriteLine("La suma del arreglo es: " + resultado);
    }

    public static int SumaArregloRecursiva(int[] arr)
    {
        if (arr == null) throw new ArgumentNullException(nameof(arr));
        return SumaDesde(arr, 0);
    }

    private static int SumaDesde(int[] arr, int i)
    {
        if (i == arr.Length) return 0;
        return arr[i] + SumaDesde(arr, i + 1);
    }
}
