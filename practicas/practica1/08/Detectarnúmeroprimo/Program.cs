//Usar un bucle for para determinar si un número ingresado por el usuario es primo o no.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce un número entero positivo: ");
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int numero) && numero > 0)
        {
            bool esPrimo = true;

            if (numero == 1)
            {
                esPrimo = false; 
            }
            else
            {
                for (int i = 2; i <= numero / 2; i++)
                {
                    if (numero % i == 0)
                    {
                        esPrimo = false;
                        break; 
                    }
                }
            }

            if (esPrimo)
                Console.WriteLine($"{numero} es un número primo.");
            else
                Console.WriteLine($"{numero} no es un número primo.");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, introduce un número entero positivo.");
        }
    }
}

