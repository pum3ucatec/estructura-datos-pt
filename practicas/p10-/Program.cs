// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int numeroSecreto = rnd.Next(1, 51); // Número aleatorio del 1 al 50
        int intento;

        Console.WriteLine("¡Adivina el número entre 1 y 50!");

        do
        {
            Console.Write("Ingresa el numero que crees que es el correcto: ");
            intento = int.Parse(Console.ReadLine());

            if (intento < numeroSecreto)
            {
                Console.WriteLine("El número es mayor.");
            }
            else if (intento > numeroSecreto)
            {
                Console.WriteLine("El número es menor.");
            }
            else
            {
                Console.WriteLine($"¡Correcto! El número era {numeroSecreto}.");
            }

        } while (intento != numeroSecreto);
    }
}
