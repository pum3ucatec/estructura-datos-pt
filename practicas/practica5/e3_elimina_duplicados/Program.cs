/* Eliminar Duplicados en un Arreglo Ordenado
Escribe un programa que elimine los elementos duplicados de un arreglo ordenado, sin usar colecciones como List o HashSet.
Ejemplo: [1, 1, 2, 2, 3, 4, 4] → [1, 2, 3, 4]. */

using System;
using System.Linq;

class ejercicio_3 {
    static void Main() {
        Console.WriteLine("Ingrese un arreglo separado por espacios:");
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); // arr = arreglo

        int j = 0; // Índice para el último elemento único
        for (int i = 1; i < arr.Length; i++) {
            if (arr[i] != arr[j]) {
                j++;
                arr[j] = arr[i];
            }
        }

        Console.WriteLine("Arreglo sin duplicados: " + string.Join(" ", arr.Take(j + 1)));
    }
}
