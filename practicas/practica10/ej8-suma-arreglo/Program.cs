using System;

class SumaArregloRecursiva
{
    public static int Sumar(int[] arr, int i)
    {
        if (i == arr.Length) return 0;
        return arr[i] + Sumar(arr, i + 1);
    }

    static void MostrarProceso(int[] arr)
    {
        Console.WriteLine("Proceso de suma del arreglo:");
        int acumulado = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            acumulado += arr[i];
            Console.WriteLine($"Paso {i + 1}: sumar {arr[i]}, acumulado = {acumulado}");
        }
    }

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n--- MENÚ SUMA ARREGLO ---");
            Console.WriteLine("1. Sumar arreglo con proceso");
            Console.WriteLine("2. Salir");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                int[] arr = { 1, 8, 5, 20, 5 };
                Console.WriteLine("Arreglo: {1, 8, 5, 20, 5}");
                MostrarProceso(arr);
                Console.WriteLine("Resultado: " + Sumar(arr, 0));
            }
        } while (opcion != 2);
    }
}
