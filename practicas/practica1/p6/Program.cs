using System;

class Program
{
    static void Main()
    {
        int numero;

        do
        {
            Console.Write("Escribe un número POSITIVO (> 0): ");
            numero = int.Parse(Console.ReadLine());

            if (numero <= 0)
                Console.WriteLine("Ups, eso no es positivo. Intenta otra vez.");

        } while (numero <= 0);

        Console.WriteLine($"¡Bien! Ingresaste {numero}, que es positivo.");
    }
}
