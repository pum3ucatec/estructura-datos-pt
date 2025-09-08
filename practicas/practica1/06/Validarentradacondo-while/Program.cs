//Pedir al usuario que introduzca un número positivo y seguir pidiendo hasta que lo haga correctamente.
using System;

class Program
{
    static void Main()
    {
        int numero;

        do
        {
            Console.Write("Por favor, introduce un número positivo: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out numero))
            {
                if (numero > 0)
                {
                    Console.WriteLine($"¡Gracias! Has introducido el número positivo: {numero}");
                    break;
                }
                else
                {
                    Console.WriteLine("El número no es positivo. Inténtalo de nuevo.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, introduce un número entero.");
            }

        } while (true);
    }
}


