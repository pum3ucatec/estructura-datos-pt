// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
       
        int[] numeros = { 2, 5, 2, 8, 2, 9 };

        Console.Write("Ingresa el número que deseas contar: ");
        int buscado = Convert.ToInt32(Console.ReadLine());

        int contador = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == buscado)
            {
                contador++;
            }
        }

        Console.WriteLine("\nArreglo: [" + string.Join(", ", numeros) + "]");
        Console.WriteLine("Número buscado: " + buscado);
        Console.WriteLine("El número aparece " + contador + " veces.");
    }
}

