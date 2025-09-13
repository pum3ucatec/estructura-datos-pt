using System;
class Ejercicio9
{
    public static bool BuscarElemento(int[] arr, int n, int valor)
    {   
        // caso base
        if (n == 0)
            return false;
        if (arr[n - 1] == valor) 
            return true;
        return BuscarElemento(arr, n - 1, valor); // llamada recursiva
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Buscar Elemento ===");

        Console.Write("Ingresa la cantidad de elementos: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Ingresa el valor a buscar: ");
        int valor = int.Parse(Console.ReadLine());

        bool encontrado = BuscarElemento(arr, n, valor);

        Console.WriteLine(encontrado ? "Elemento encontrado." : "Elemento no encontrado.");
    }
}
