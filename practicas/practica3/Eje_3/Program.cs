// Suma de los elementos de un arreglo
using System;
class Program
{
    static void Main()
    {
        int[] numeros = { 20, 51, 49, 56, 55 };
        int suma = 0;

        foreach (int numero in numeros)
        {
            suma += numero;
        }

        Console.WriteLine("La suma de los elementos del arreglo es: " + suma);
    }
}
