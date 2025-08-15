// Crear un pequeño menú que se repita hasta que el usuario elija salir (Ejemplo: 1.Saludar, 2.Sumar, 3.Salir)

using System;
namespace EjerciciosCSharp
{
    class Program
    {
        static void Main()
        {
            // ----- 4. Menú con do-while -----
            int opcion;
            do
            {
                Console.WriteLine("\n--- MENÚ ---");
                Console.WriteLine("1. Saludar");
                Console.WriteLine("2. Sumar");
                Console.WriteLine("3. Salir");
                Console.Write("Elija una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("¡Holaaaaa!!!");
                        break;
                    case 2:
                        Console.Write("Ingrese el primer número: ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        int num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"El resultado de la suma es: {num1 + num2}");
                        break;
                    case 3:
                        Console.WriteLine("Saliendo del menú...");
                         Console.WriteLine("Hasta luego");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != 3);
        }
    }
}