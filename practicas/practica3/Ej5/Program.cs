// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {

        int[] numeros = new int[8];

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Ingresa el número #" + (i + 1) + ": ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        int mayor = numeros[0];
        int menor = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > mayor)
                mayor = numeros[i];
            if (numeros[i] < menor)
                menor = numeros[i];
        }

        Console.WriteLine("\nEl número mayor es: " + mayor);
        Console.WriteLine("El número menor es: " + menor);
    }
}

