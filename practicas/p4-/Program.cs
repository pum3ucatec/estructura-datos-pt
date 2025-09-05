// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n--- MENÚ ---");
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Decir la hora");
            Console.WriteLine("3. Salir");
            Console.Write("Elija una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("¡Hola! Espero que tengas un gran día hoy.");
                    break;
                case 2:
                    Console.WriteLine("La hora actual es: " + DateTime.Now.ToString("HH:mm:ss"));
                    break;
                case 3:
                    Console.WriteLine("Saliendo del programa. Adiós!");
                    break;
                default:
                    Console.WriteLine("Opción no válida, intenta de nuevo.");
                    break;
            }

        } while (opcion != 3);
    }
}

