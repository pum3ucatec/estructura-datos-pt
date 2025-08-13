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
            Console.WriteLine("2. Sumar dos números");
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("¡Hola! 😊");
                    break;
                case 2:
                    Console.Write("Ingresa el primer número: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Ingresa el segundo número: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine($"La suma es: {a + b}");
                    break;
                case 3:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        } while (opcion != 3);
    }
}

