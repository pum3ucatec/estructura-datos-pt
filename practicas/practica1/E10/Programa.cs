using System;

class AdivinaNumero
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 51); // Genera un número entre 1 y 50
        int intento;

        Console.WriteLine(" Adivina el número entre 1 y 50");

        do
        {
            Console.Write(" Ingresa tu intento: ");
            intento = int.Parse(Console.ReadLine());

            if (intento > numeroSecreto)
                Console.WriteLine("El número secreto es MENOR.");
            else if (intento < numeroSecreto)
                Console.WriteLine("El número secreto es MAYOR.");

        } while (intento != numeroSecreto);

        Console.WriteLine(" ¡Felicidades! Adivinaste el número.");
    }
}
