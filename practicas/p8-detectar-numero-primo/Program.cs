using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número: ");
            int numero = int.Parse(Console.ReadLine());
            bool esPrimo = true;

            if (numero < 2)
            {
                esPrimo = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
            }

            if (esPrimo)
                Console.WriteLine("Es primo");
            else
                Console.WriteLine("No es primo");
        }
    }
}