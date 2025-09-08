using System;

class BuscarEnArregloRecursiva
{
    public static bool Buscar(int[] arr, int i, int valor)
    {
        if (i == arr.Length) return false;
        if (arr[i] == valor) return true;
        return Buscar(arr, i + 1, valor);
    }

    static void MostrarProceso(int[] arr, int valor)
    {
        Console.WriteLine("Proceso de búsqueda:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Paso {i + 1}: comparando {arr[i]} con {valor}");
            if (arr[i] == valor)
            {
                Console.WriteLine($"Valor {valor} encontrado en la posición {i}");
                break;
            }
        }
    }

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n--- MENÚ BUSCAR EN ARREGLO ---");
            Console.WriteLine("1. Buscar valor con proceso");
            Console.WriteLine("2. Salir");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                int[] arr = { 10, 55, 25, 43 };
                Console.WriteLine("Arreglo: {10, 55, 25, 43}");
                Console.Write("Ingrese valor a buscar: ");
                int valor = int.Parse(Console.ReadLine());
                MostrarProceso(arr, valor);
                Console.WriteLine(Buscar(arr, 0, valor) ? "Resultado: Encontrado" : "Resultado: No encontrado");
            }
        } while (opcion != 2);
    }
}
