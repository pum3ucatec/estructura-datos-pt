// See https://aka.ms/new-console-template for more information
using System;

class CalculadoraCientifica
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Calculadora Científica ===");
            Console.WriteLine("Seleccione una operación:");
            Console.WriteLine("1. Suma (+)");
            Console.WriteLine("2. Resta (-)");
            Console.WriteLine("3. Multiplicación (*)");
            Console.WriteLine("4. División (/)");
            Console.WriteLine("5. Raíz cuadrada (√)");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");
            
            string opcion = Console.ReadLine();

            if (opcion == "0")
                break;

            double num1 = 0, num2 = 0, resultado = 0;

            if (opcion == "5")
            {
                
                Console.Write("Ingrese un número: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                resultado = Math.Sqrt(num1);
                Console.WriteLine($"√{num1} = {resultado}");
            }
            else
            {

                Console.Write("Ingrese el primer número: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                switch (opcion)
                {
                    case "1":
                        resultado = num1 + num2;
                        Console.WriteLine($"{num1} + {num2} = {resultado}");
                        break;
                    case "2":
                        resultado = num1 - num2;
                        Console.WriteLine($"{num1} - {num2} = {resultado}");
                        break;
                    case "3":
                        resultado = num1 * num2;
                        Console.WriteLine($"{num1} * {num2} = {resultado}");
                        break;
                    case "4":
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine($"{num1} / {num2} = {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Error: División entre cero no permitida.");
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}

