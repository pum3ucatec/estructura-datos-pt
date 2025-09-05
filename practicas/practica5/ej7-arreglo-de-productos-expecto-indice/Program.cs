// ## 7. Arreglo de Productos Excepto el Índice
// Dado un arreglo de enteros, construye un nuevo arreglo donde cada posición contenga el producto de todos los elementos excepto el de esa posición (sin usar división).  
// Ejemplo: `[1, 2, 3, 4]` → `[24, 12, 8, 6]`.
// Camii 
using System;

class Ejercicio7
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4 };
        int n = arr.Length;

        int[] izquierda = new int[n];
        int[] derecha = new int[n];
        int[] resultado = new int[n];

        izquierda[0] = 1;
        for (int i = 1; i < n; i++)
            izquierda[i] = izquierda[i - 1] * arr[i - 1];

        derecha[n - 1] = 1;
        for (int i = n - 2; i >= 0; i--)
            derecha[i] = derecha[i + 1] * arr[i + 1];

        for (int i = 0; i < n; i++)
            resultado[i] = izquierda[i] * derecha[i];

        Console.WriteLine("Resultado: " + string.Join(", ", resultado));
    }
}
