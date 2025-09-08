//El sistema genera un número aleatorio del 1 al 50.
//El usuario intenta adivinarlo.
//Usar do-while hasta que acierte, indicando si es mayor o menor.
using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 51); 
        int intento;

        Console.WriteLine("¡Adivina el número secreto entre 1 y 50!");

        do
        {
            Console.Write("Introduce tu intento: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out intento))
            {
                if (intento < numeroSecreto)
                {
                    Console.WriteLine("Demasiado bajo. Intenta con un número mayor.");
                }
                else if (intento > numeroSecreto)
                {
                    Console.WriteLine("Demasiado alto. Intenta con un número menor.");
                }
                else
                {
                    Console.WriteLine($"¡Correcto! El número secreto era {numeroSecreto} 🎉");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, introduce un número entero.");
            }

        } while (intento != numeroSecreto);
    }
}
