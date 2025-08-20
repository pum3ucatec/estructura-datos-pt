using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 4, 5, 6, 7, 0, 1, 2 };
        int objetivo = 0;

        Console.WriteLine("Arreglo rotado:");
        ImprimirArreglo(numeros);

        int indice = BuscarEnRotado(numeros, objetivo);

        if (indice != -1)
            Console.WriteLine($"\nEl número {objetivo} se encuentra en el índice {indice}.");
        else
            Console.WriteLine($"\nEl número {objetivo} no se encuentra en el arreglo.");
    }

    // Búsqueda en arreglo rotado usando búsqueda binaria modificada
    static int BuscarEnRotado(int[] arr, int objetivo)
    {
        int izquierda = 0, derecha = arr.Length - 1;

        while (izquierda <= derecha)
        {
            int medio = (izquierda + derecha) / 2;

            if (arr[medio] == objetivo)
                return medio;

            // Verificar si la mitad izquierda está ordenada
            if (arr[izquierda] <= arr[medio])
            {
                if (objetivo >= arr[izquierda] && objetivo < arr[medio])
                    derecha = medio - 1;
                else
                    izquierda = medio + 1;
            }
            // Sino, la mitad derecha está ordenada
            else
            {
                if (objetivo > arr[medio] && objetivo <= arr[derecha])
                    izquierda = medio + 1;
                else
                    derecha = medio - 1;
            }
        }
        return -1;
    }

    // Método auxiliar para imprimir arreglo
    static void ImprimirArreglo(int[] arr)
    {
        foreach (var num in arr)
            Console.Write(num + " ");
        Console.WriteLine();
    }
}
