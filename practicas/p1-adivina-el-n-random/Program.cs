using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 51);
        int intento;
        int intentos = 0;

        Console.WriteLine("Adivina el número (entre 1 y 50):");

        do
        {
            Console.Write("Tu intento: ");
            intento = int.Parse(Console.ReadLine());
            intentos++;

            if (intento < numeroSecreto)
                Console.WriteLine("Muy bajo");
            else if (intento > numeroSecreto)
                Console.WriteLine("Muy alto");

        } while (intento != numeroSecreto);

        Console.WriteLine($"¡Correcto! Lo lograste en {intentos} intentos.");
    }
}

