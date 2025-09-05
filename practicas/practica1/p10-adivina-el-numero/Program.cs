// Adivina el número
//El sistema genera un número aleatorio del 1 al 50.
//El usuario intenta adivinarlo.
//Usar do-while hasta que acierte, indicando si es mayor o menor.
//Camilaa
using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 51);
        int intento;
        int intentosRealizados = 0;
        
        Console.WriteLine("Adivina el número entre 1 y 50");
        
        do
        {
            Console.Write("Ingresa tu intento: ");
            intento = int.Parse(Console.ReadLine());
            intentosRealizados++;
            
            if (intento < numeroAleatorio)
            {
                Console.WriteLine("El número es mayor.");
            }
            else if (intento > numeroAleatorio)
            {
                Console.WriteLine("El número es menor.");
            }
            
        } while (intento != numeroAleatorio);
        
        Console.WriteLine($"¡Felicidades! Muy bien adivinaste el número en {intentosRealizados} intentos.");
    }
}
