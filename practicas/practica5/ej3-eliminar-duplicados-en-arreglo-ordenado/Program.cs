// ## 3. Eliminar Duplicados en un Arreglo Ordenado
// Escribe un programa que elimine los elementos duplicados de un arreglo **ordenado**, sin usar colecciones como `List` o `HashSet`.  
// Ejemplo: `[1, 1, 2, 2, 3, 4, 4]` → `[1, 2, 3, 4]`.
// Camii

using System;

class Ejercicio3
{
    static void Main()
    {
        int[] arr = { 1, 1, 2, 2, 3, 4, 4 };
        int n = arr.Length;

        // Usamos puntero lento
        int j = 0;
        for (int i = 1; i < n; i++)
        {
            if (arr[j] != arr[i])
            {
                j++;
                arr[j] = arr[i];
            }
        }

        Console.WriteLine("Arreglo sin duplicados:");
        for (int i = 0; i <= j; i++)
            Console.Write(arr[i] + " ");
    }
}

