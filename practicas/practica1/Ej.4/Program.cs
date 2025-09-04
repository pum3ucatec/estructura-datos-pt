using System;

namespace MenuDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. SUMA");
                Console.WriteLine("2. RESTA");
                Console.WriteLine("3. MULTIPLICACION");
                Console.WriteLine("4. Salir");
                Console.Write("Selecciona una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        // Lógica para la suma
                        Console.Write("Ingrese el primer número: ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        int num2 = int.Parse(Console.ReadLine());
                        int suma = num1 + num2;
                        Console.WriteLine($"La suma es: {suma}");
                        break;
                    case 2:
                        // Lógica para la resta
                        Console.Write("Ingrese el primer número: ");
                        int num3 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        int num4 = int.Parse(Console.ReadLine());
                        int resta = num3 - num4;
                        Console.WriteLine($"La resta es: {resta}");
                        break;
                    case 3:
                        // Lógica para la multiplicación
                        Console.Write("Ingrese el primer número: ");
                        int num5 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        int num6 = int.Parse(Console.ReadLine());
                        int multiplicacion = num5 * num6;
                        Console.WriteLine($"La multiplicación es: {multiplicacion}");
                        break;
                    case 4:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intenta de nuevo.");
                        break;
                }

            } while (opcion != 4);
        }
    }
}