// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int secreto = random.Next(1, 51); // Número entre 1 y 50
        int intento;

        do
        {
            Console.Write("Adivina el número (1-50): ");
            intento = int.Parse(Console.ReadLine());

            if (intento < secreto)
                Console.WriteLine("El número secreto es mayor.");
            else if (intento > secreto)
                Console.WriteLine("El número secreto es menor.");

        } while (intento != secreto);

        Console.WriteLine($"¡Felicidades! El número era {secreto}");
    }
}
