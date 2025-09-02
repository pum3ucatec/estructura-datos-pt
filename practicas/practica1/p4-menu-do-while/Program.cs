using System;

class Programa
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
                    Console.WriteLine("¡Hola! Espero que estés bien.");
                    break;
                case 2:
                    Console.Write("Ingrese el primer número: ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"La suma es: {num1 + num2}");
                    break;
                case 3:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    break;
            }
        } while (opcion != 3);
    }
}
