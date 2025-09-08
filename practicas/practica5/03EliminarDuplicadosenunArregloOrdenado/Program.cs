// Escribe un programa que elimine los elementos duplicados de un arreglo **ordenado**, sin usar colecciones como `List` o `HashSet`. 
using System;

class Programa
{
    static void Main()
    {
        int[] arreglo = { 1, 1, 2, 2, 3, 4, 4 };

        int[] sinDuplicados = EliminarDuplicadosOrdenados(arreglo, out int nuevoTam);

        Console.WriteLine("Arreglo sin duplicados:");
        for (int i = 0; i < nuevoTam; i++)
        {
            Console.Write(sinDuplicados[i] + " ");
        }
    }

    static int[] EliminarDuplicadosOrdenados(int[] arreglo, out int nuevoTam)
    {
        if (arreglo.Length == 0)
        {
            nuevoTam = 0;
            return new int[0];
        }

        int[] resultado = new int[arreglo.Length];
        int j = 0;

        resultado[j++] = arreglo[0];

        for (int i = 1; i < arreglo.Length; i++)
        {
            if (arreglo[i] != arreglo[i - 1])
            {
                resultado[j++] = arreglo[i];
            }
        }

        nuevoTam = j;
        return resultado;
    }
}
