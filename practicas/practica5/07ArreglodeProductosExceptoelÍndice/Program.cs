// Dado un arreglo de enteros, construye un nuevo arreglo donde cada posición contenga el producto de todos los elementos excepto el de esa posición (sin usar división). 
using System;

class Programa
{
    static void Main()
    {
        int[] arreglo = { 1, 2, 3, 4 };
        int[] resultado = ProductoExceptoPosicion(arreglo);

        Console.WriteLine("Resultado:");
        foreach (int num in resultado)
        {
            Console.Write(num + " ");
        }
    }

    static int[] ProductoExceptoPosicion(int[] arreglo)
    {
        int n = arreglo.Length;
        int[] izquierda = new int[n];
        int[] derecha = new int[n];
        int[] resultado = new int[n];

        izquierda[0] = 1;
        for (int i = 1; i < n; i++)
        {
            izquierda[i] = izquierda[i - 1] * arreglo[i - 1];
        }

        derecha[n - 1] = 1;
        for (int i = n - 2; i >= 0; i--)
        {
            derecha[i] = derecha[i + 1] * arreglo[i + 1];
        }

        for (int i = 0; i < n; i++)
        {
            resultado[i] = izquierda[i] * derecha[i];
        }

        return resultado;
    }
}
