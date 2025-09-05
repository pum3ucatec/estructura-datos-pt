// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int[] Numeros = new int[10];

        for (int i = 0; i < Numeros.Length; i++)
        {
            Console.Write("Ingresa el número #" + (i + 1) + ": ");
            Numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("\nIngresa el número que deseas buscar: ");
        int Buscado = Convert.ToInt32(Console.ReadLine());

        bool Encontrado = false;

        for (int i = 0; i < Numeros.Length; i++)
        {
            if (Numeros[i] == Buscado)
            {
                Console.WriteLine("El número " + Buscado + " se encuentra en la posición: " + i);
                Encontrado = true;
                break;
            }
        }

        if (!Encontrado)
        {
            Console.WriteLine("El número " + Buscado + " no se encuentra en el arreglo.");
        }
    }
}

