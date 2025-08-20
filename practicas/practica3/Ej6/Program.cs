// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Ingresa el número #" + (i + 1) + ": ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("\nIngresa el número que deseas buscar: ");
        int buscado = Convert.ToInt32(Console.ReadLine());

        bool encontrado = false;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == buscado)
            {
                Console.WriteLine("El número " + buscado + " se encuentra en la posición: " + i);
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("El número " + buscado + " no se encuentra en el arreglo.");
        }
    }
}

