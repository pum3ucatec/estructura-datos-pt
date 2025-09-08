using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int numeroSecreto = rnd.Next(1, 51);
        int intento;

        Console.WriteLine("Adivina el número del 1 al 50:");

        do
        {
            Console.Write("Ingrese su intento: ");
            intento = int.Parse(Console.ReadLine());

            if (intento < numeroSecreto)
                Console.WriteLine("Es mayor");
            else if (intento > numeroSecreto)
                Console.WriteLine("Es menor");
            else
                Console.WriteLine("¡Correcto! Has adivinado el número.");
        } while (intento != numeroSecreto);
    }
}
