using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int positivo;
            do
            {
                Console.Write("Ingresa un número positivo: ");
                positivo = int.Parse(Console.ReadLine());
            } while (positivo <= 0);

            Console.WriteLine("Número válido: " + positivo);
        }
    }
}

