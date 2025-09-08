using System;

class Program
{
    static void Main()
    {
        var random = new Random();
        int secreto = random.Next(1, 101); 
        int intentos = 0;

        Console.WriteLine("He pensado un número entre 1 y 100. ¡Adivínalo!");

        while (true)
        {
            Console.Write("Tu intento: ");
            string? entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out int guess))
            {
                Console.WriteLine("Por favor, escribe un número válido.");
                continue;
            }

            intentos++;

            if (guess < 1 || guess > 100)
            {
                Console.WriteLine("Debe estar entre 1 y 100.");
                continue;
            }

            if (guess == secreto)
            {
                Console.WriteLine($"¡Correcto! El número era {secreto}. Intentos: {intentos}");
                break; 
            }
            else if (guess < secreto)
            {
                Console.WriteLine("Muy bajo. Prueba un número más GRANDE.");
            }
            else
            {
                Console.WriteLine("Muy alto. Prueba un número más PEQUEÑO.");
            }
        }
    }
}