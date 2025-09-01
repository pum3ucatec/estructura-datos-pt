using System;

class Ejercicio4
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Sumar dos números");
            Console.WriteLine("3. Salir");
            Console.Write("Elija una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("¡Hola! ¿Cómo estás?");
                    break;
                case 2:
                    Console.Write("Ingrese el primer número: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine($"La suma es: {a + b}");
                    break;
                case 3:
                    Console.WriteLine("Saliendo del menú...");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            Console.WriteLine();

        } while (opcion != 3);
    }
}
