using System;

class Ejercicio10_Adivina
{
    static void Main()
    {
        Random rnd = new Random();
        int secreto = rnd.Next(1, 51); // número entre 1 y 50
        int intento;

        Console.WriteLine("Adivina el número entre 1 y 50");

        do
        {
            Console.Write("Ingresa tu intento: ");
            intento = int.Parse(Console.ReadLine());

            if (intento > secreto)
                Console.WriteLine("Es menor.");
            else if (intento < secreto)
                Console.WriteLine("Es mayor.");
        } while (intento != secreto);

        Console.WriteLine("¡Felicidades! Adivinaste el número.");
    }
}