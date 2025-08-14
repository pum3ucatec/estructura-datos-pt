// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int numero;

        do
        {
            Console.Write("Ingrese un número positivo: ");
            numero = int.Parse(Console.ReadLine());

            if (numero <= 0)
            {
                Console.WriteLine("Error: El número debe ser mayor que 0.");
            }

        } while (numero <= 0);

        Console.WriteLine($"Número válido ingresado: {numero}");
    }
}

