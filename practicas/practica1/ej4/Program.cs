using System;

class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n===== MENÚ =====");
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Sumar");
            Console.WriteLine("3. Salir");
            Console.Write("Elija una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("¡Hola, usuario!");
                    break;
                case 2:
                    Console.Write("Ingrese un número: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese otro número: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine($"La suma es: {a + b}");
                    break;
                case 3:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        } while (opcion != 3);
    }
}
