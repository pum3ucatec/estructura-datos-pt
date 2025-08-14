using System;

class Programa
{
    static void Main()
    {
        Random rnd = new Random();
        int secreto = rnd.Next(1, 51); // Número aleatorio entre 1 y 50
        int intento;

        Console.WriteLine("🎯 Adivina el número (1 a 50)");

        do
        {
            Console.Write("Ingresa tu intento: ");
            intento = int.Parse(Console.ReadLine());

            if (intento < secreto)
                Console.WriteLine("📉 El número es mayor.");
            else if (intento > secreto)
                Console.WriteLine("📈 El número es menor.");
            else
                Console.WriteLine("🎉 ¡Acertaste!");

        } while (intento != secreto);
    }
}
