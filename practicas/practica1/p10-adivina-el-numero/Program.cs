using System;
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int numAdivinar = random.Next(1, 101);
        int numero = 0;

        Console.WriteLine("Adivina el numero entre 1 y 100:");

        while (numAdivinar != numero)
        {
            Console.Write("Introduce un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 100 || numero < 1)
            {
                Console.WriteLine("Numero no valido, ¡¡intenta de nuevo!!");
            }
            else
            {
                if (numero < numAdivinar)
                {
                    Console.WriteLine("Demasiado bajo. Intenta de nuevo.");
                }
                else if (numero > numAdivinar)
                {
                    Console.WriteLine("Demasiado alto. Intenta de nuevo.");
                }
                else
                {
                    Console.WriteLine("¡¡¡Felicidades!!! ¡¡¡Felicidades!!! ¡¡¡Felicidades!!!");
                    Console.WriteLine("¡¡Has adivinado el numero!!!");
                }


            }
        }
    }
}