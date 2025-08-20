using System;

class Ejercicio3
{
    static void Main()
    {
        int[] arreglo = { 5, 10, 15, 20 };
        int suma = 0;

        for (int i = 0; i < arreglo.Length; i++)
        {
            suma += arreglo[i];
        }

        Console.WriteLine("Suma: " + suma);
    }
}

