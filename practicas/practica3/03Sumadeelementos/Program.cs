//Dado un arreglo de enteros, calcula la suma de todos sus elementos. 
using System;

class Program
{
    static void Main()
    {

        int[] numeros = { 5, 10, 15, 20 };

        int suma = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            suma += numeros[i];
        }

        Console.WriteLine($"La suma de los elementos es: {suma}");
    }
}
