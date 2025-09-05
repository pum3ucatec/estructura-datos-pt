// Dado un arreglo **rotado y ordenado** (ej. `[4,5,6,7,0,1,2]`), implementa búsqueda binaria modificada para encontrar un número dado.
using System;

class Programa
{
    static void Main()
    {
        int[] arreglo = { 4, 5, 6, 7, 0, 1, 2 };
        int objetivo = 0;

        int indice = BuscarEnRotado(arreglo, objetivo);

        if (indice != -1)
            Console.WriteLine("Elemento encontrado en el índice: " + indice);
        else
            Console.WriteLine("Elemento no encontrado.");
    }

    static int BuscarEnRotado(int[] arreglo, int objetivo)
    {
        int inicio = 0;
        int fin = arreglo.Length - 1;

        while (inicio <= fin)
        {
            int medio = (inicio + fin) / 2;

            if (arreglo[medio] == objetivo)
                return medio;

            if (arreglo[inicio] <= arreglo[medio])
            {
                if (objetivo >= arreglo[inicio] && objetivo < arreglo[medio])
                    fin = medio - 1;
                else
                    inicio = medio + 1;
            }
   
            else
            {
                if (objetivo > arreglo[medio] && objetivo <= arreglo[fin])
                    inicio = medio + 1;
                else
                    fin = medio - 1;
            }
        }

        return -1;
    }
}

