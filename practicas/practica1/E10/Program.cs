using System;

class JuegoAdivinaNumero
{
    static void Main()
    {
        Random generador = new Random();
        int numeroSecreto = generador.Next(1, 51); // número aleatorio entre 1 y 50
        int intentoUsuario;
        int contadorIntentos = 0;

        Console.WriteLine(" ¡Bienvenido al juego de Adivina el Número!");

        do
        {
            Console.Write("Ingresa tu intento (1-50): ");
            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out intentoUsuario))
            {
                Console.WriteLine(" Entrada inválida. Por favor ingresa un número entero.");
                continue;
            }

            contadorIntentos++;

            if (intentoUsuario < numeroSecreto)
                Console.WriteLine("⬆ Más alto...");
            else if (intentoUsuario > numeroSecreto)
                Console.WriteLine("⬇ Más bajo...");
            else
                Console.WriteLine($" ¡Correcto! Adivinaste el número {numeroSecreto} en {contadorIntentos} intentos.");

        } while (intentoUsuario != numeroSecreto);
    }
}
