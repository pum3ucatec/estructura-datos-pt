using System;

class Program
{
    static void Main()
    {
        int[] arr = { 4, 5, 6, 7, 0, 1, 2 };
        int target = 0;

        Console.WriteLine("Arreglo rotado:");
        ImprimirArreglo(arr);

        int indice = BuscarEnRotado(arr, target);

        if (indice != -1)
            Console.WriteLine($"\nEl elemento {target} se encuentra en el índice {indice}.");
        else
            Console.WriteLine($"\nEl elemento {target} no se encuentra en el arreglo.");
    }

    static int BuscarEnRotado(int[] arr, int target)
    {
        int inicio = 1, fin = arr.Length - 1;

        while (inicio <= fin)
        {
            int medio = (inicio + fin) / 2;

            // Si encontramos el target
            if (arr[medio] == target)
                return medio;

            // Lado izquierdo ordenado
            if (arr[inicio] <= arr[medio])
            {
                if (target >= arr[inicio] && target < arr[medio])
                    fin = medio - 1;
                else
                    inicio = medio + 1;
            }
            // Lado derecho ordenado
            else
            {
                if (target > arr[medio] && target <= arr[fin])
                    inicio = medio + 1;
                else
                    fin = medio - 1;
            }
        }

        return -1; // No encontrado
    }

    static void ImprimirArreglo(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
