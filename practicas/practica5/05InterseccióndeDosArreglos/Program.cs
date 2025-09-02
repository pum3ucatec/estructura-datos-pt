// Dado dos arreglos de enteros, encuentra los elementos comunes sin usar LINQ. 
using System;

class Programa
{
    static void Main()
    {
        int[] arregloA = { 1, 2, 2, 1 };
        int[] arregloB = { 2, 2 };

        int[] comunes = EncontrarComunes(arregloA, arregloB, out int tamComunes);

        Console.WriteLine("Elementos comunes:");
        for (int i = 0; i < tamComunes; i++)
        {
            Console.Write(comunes[i] + " ");
        }
    }

    static int[] EncontrarComunes(int[] a, int[] b, out int tamComunes)
    {
        bool[] usados = new bool[b.Length]; 
        int[] resultado = new int[Math.Min(a.Length, b.Length)];
        int k = 0;

        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < b.Length; j++)
            {
                if (a[i] == b[j] && !usados[j])
                {
                    resultado[k++] = a[i];
                    usados[j] = true; 
                    break;
                }
            }
        }

        tamComunes = k;
        return resultado;
    }
}

