// Dado un arreglo de enteros, calcula la suma de todos sus elementos.  

using System;
class Ejercicio3
{
    static void Main()
    {
        int[] numeros = { 5, 10, 15, 20 };
        int suma = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            suma += numeros[i];
        }

        Console.WriteLine("la suma es:" + suma);
    }
}

