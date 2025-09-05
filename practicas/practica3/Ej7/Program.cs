// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int[] Numeros = { 2, 5, 2, 8, 2, 9 };

        Console.Write("Ingresa el número que deseas contar: ");
        int Buscado = Convert.ToInt32(Console.ReadLine());

        int Contador = 0;

        for (int i = 0; i < Numeros.Length; i++)
        {
            if (Numeros[i] == Buscado)
            {
                Contador++;
            }
        }

        Console.WriteLine("\nArreglo: [" + string.Join(", ", Numeros) + "]");
        Console.WriteLine("Número buscado: " + Buscado);
        Console.WriteLine("El número aparece " + Contador + " veces.");
    }
}

