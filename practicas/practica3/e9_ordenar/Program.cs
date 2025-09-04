/* 9. Ordenamiento (básico)
Implementa un algoritmo sencillo (por ejemplo, Burbuja) para ordenar un arreglo de enteros de menor a mayor. */

using System;

class ejercicio_9
{
    static void Main()
    {
        int[] datos = { 8, 3, 5, 1, 9 };

        Console.WriteLine("Arreglo desordenado: [" + string.Join(", ", datos) + "]");

        for (int pasada = 0; pasada < datos.Length - 1; pasada++)
        {
            bool hubo_intercambio = false;

            for (int i = 0; i < datos.Length - 1 - pasada; i++)
            {
                if (datos[i] > datos[i + 1])
                {
                    int aux = datos[i];
                    datos[i] = datos[i + 1];
                    datos[i + 1] = aux;
                    hubo_intercambio = true;
                }
            }

            if (!hubo_intercambio) break;
        }

        Console.WriteLine("Arreglo ordenado:   [" + string.Join(", ", datos) + "]");
    }
}
