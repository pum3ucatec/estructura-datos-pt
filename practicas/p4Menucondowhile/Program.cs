using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("1. Saludar");
                Console.WriteLine("2. Sumar 2 números");
                Console.WriteLine("3. Salir");
                Console.Write("Elige una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("¡Hola buenas tardes!");
                        break;
                    case 2:
                        Console.Write("Número 1: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Número 2: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Suma: " + (a + b));
                        break;
                    case 3:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            } while (opcion != 3);
        }
    }
}