using System;

class Ejercicio4_Menu
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n--- MENÚ ---");
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Sumar");
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("¡Hola! Espero que tengas un buen día.");
                    break;
                case 2:
                    Console.Write("Ingrese primer número: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese segundo número: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Resultado: " + (a + b));
                    break;
                case 3:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (opcion != 3);
    }
}