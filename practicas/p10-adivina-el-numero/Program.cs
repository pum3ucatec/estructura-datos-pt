using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int aleatorio = rnd.Next(1, 51);
            int intento;

            Console.WriteLine("Adivina el número (1-50):");

            do
            {
                Console.Write("Tu intento: ");
                intento = int.Parse(Console.ReadLine());

                if (intento < aleatorio)
                    Console.WriteLine("Más alto");
                else if (intento > aleatorio)
                    Console.WriteLine("Más bajo");

            } while (intento != aleatorio);

            Console.WriteLine("¡Correcto! El número era " + aleatorio);
        }
    }
}
