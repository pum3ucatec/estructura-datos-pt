// Menu con do-while
// Crear un pequeño menu que se repita hasta que el usuario  elija salir (1.- Saludar, 2.- Sumar, 3.- Salir)
// Camilaa
using System;

class Program
{
    static void Main()
    {
        int opcion;
        
        do
        {
            Console.WriteLine("MENÚ");
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Sumar");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());
            
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("¡Hola! Bienvenid@ al programa .");
                    break;
                case 2:
                    Console.Write("Ingrese primer número: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese segundo número: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine($"La suma es: {a + b}");
                    break;
                case 3:
                    Console.WriteLine("Saliendo del programa... que tengas un bonito dia :)");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
            
        } while (opcion != 3);
    }
}