// El sistema genera un número aleatorio del 1 al 50. El usuario intenta adivinarlo. 
// Usar do-while hasta que acierte, indicando si es mayor o menor.

using System;

namespace Adivina_el_número_juego
{
    class Ejercicio10
    {
        static void Main()
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 51);
            int intento;
            do
            {
                Console.Write("Adivina el número (1 al 50): ");
                intento = int.Parse(Console.ReadLine());

                if (intento < numeroSecreto)
                    Console.WriteLine("El número secreto es mayor.");
                else if (intento > numeroSecreto)
                    Console.WriteLine("El número secreto es menor.");

            } while (intento != numeroSecreto);

            Console.WriteLine("¡Felicidades! Adivinaste el número.");
        }
    }
}
