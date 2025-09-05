// Pedir al usuario que introduzca un número positivo y seguir pidiendo hasta que lo haga correctamente.

using System;


    class Ejercicio6
    {
        static void Main()
        {
            int numeroPositivo;
            do
            {
                Console.Write("Ingrese un número positivo: ");
                numeroPositivo = int.Parse(Console.ReadLine());
            } while (numeroPositivo <= 0);
            Console.WriteLine($"Número válido ingresado: {numeroPositivo}");
        }
    }

