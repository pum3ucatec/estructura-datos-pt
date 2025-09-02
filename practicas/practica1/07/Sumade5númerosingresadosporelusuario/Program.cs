//Pedir al usuario 5 números (uno por uno) y sumarlos usando for.
using System;

class Program
{
    static void Main()
    {
        int suma = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Introduce el número #{i}: ");
            string entrada = Console.ReadLine();

            // Validamos que sea un número entero
            if (int.TryParse(entrada, out int numero))
            {
                suma += numero;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, introduce un número entero.");
                i--; // Repetimos esta iteración
            }
        }

        Console.WriteLine($"La suma total de los 5 números es: {suma}");
    }
}

