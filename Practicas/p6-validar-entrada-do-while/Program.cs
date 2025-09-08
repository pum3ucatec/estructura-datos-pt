// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int numero;
        do
        {
            Console.Write("Introduce un número positivo: ");
            numero = int.Parse(Console.ReadLine());
        } while (numero <= 0);

        Console.WriteLine($"Número válido: {numero}");
    }
}

