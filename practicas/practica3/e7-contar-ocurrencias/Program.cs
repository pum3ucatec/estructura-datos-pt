// Dado un arreglo de enteros, pide un número y cuenta cuántas veces aparece en el arreglo.  
using System;
class Ejercicio7
{
    static void Main()
    {
        int[] numeros = { 7, 23, 12, 45, 2, 4, 4, 7, 8, 4, 2 };

        Console.Write("Ingresa un número a buscar: ");
        int buscado = int.Parse(Console.ReadLine());

        int contador = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == buscado)
            {
                contador++; 
            }
        }

        if (contador > 0)
        {
            Console.WriteLine($"El número {buscado} aparece {contador} veces en el arreglo.");
        }
        else
        {
            Console.WriteLine($"El número {buscado} no se encuentra en el arreglo.");
        }
    }
}

    