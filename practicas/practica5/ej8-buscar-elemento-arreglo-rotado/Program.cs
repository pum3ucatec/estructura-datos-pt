// ## 8. Buscar Elemento en Arreglo Rotado
// Dado un arreglo **rotado y ordenado** (ej. `[4,5,6,7,0,1,2]`), implementa búsqueda binaria modificada para encontrar un número dado.
// camii

using System;

class Ejercicio8
{
    static int Buscar(int[] arr, int objetivo)
    {
        int inicio = 0, fin = arr.Length - 1;

        while (inicio <= fin)
        {
            int mid = (inicio + fin) / 2;

            if (arr[mid] == objetivo) return mid;

            // Lado izquierdo ordenado
            if (arr[inicio] <= arr[mid])
            {
                if (objetivo >= arr[inicio] && objetivo < arr[mid])
                    fin = mid - 1;
                else
                    inicio = mid + 1;
            }
            else // Lado derecho ordenado
            {
                if (objetivo > arr[mid] && objetivo <= arr[fin])
                    inicio = mid + 1;
                else
                    fin = mid - 1;
            }
        }

        return -1;
    }

    static void Main()
    {
        int[] arr = { 4, 5, 6, 7, 0, 1, 2 };
        int objetivo = 0;

        Console.WriteLine("Índice encontrado: " + Buscar(arr, objetivo));
    }
}
