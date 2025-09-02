using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int secreto = rnd.Next(1, 51); // número secreto entre 1 y 50

        int intento;
        int intentos = 0;

        do
        {
            Console.Write("Adivina el número (1..50): ");
            intento = int.Parse(Console.ReadLine());
            intentos++;

            if (intento < secreto)
                Console.WriteLine("Más grande 🔼");
            else if (intento > secreto)
                Console.WriteLine("Más pequeño 🔽");

        } while (intento != secreto);

        Console.WriteLine($"🎉 ¡Correcto! El número era {secreto}. Lo lograste en {intentos} intentos.");
    }
}
