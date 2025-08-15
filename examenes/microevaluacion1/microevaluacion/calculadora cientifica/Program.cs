using System;

namespace CalculadoraCientifica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "🔢 Calculadora Científica - C#";

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("==============================================");
                Console.WriteLine("     🔢 CALCULADORA CIENTÍFICA - C# ");
                Console.WriteLine("==============================================");
                Console.ResetColor();
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Raíz cuadrada");
                Console.WriteLine("6. Calcular expresión (con paréntesis)");
                Console.WriteLine("7. Logaritmo (base 10)");
                Console.WriteLine("8. Seno");
                Console.WriteLine("9. Coseno");
                Console.WriteLine("==============================================");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        OperacionBasica("+");
                        break;
                    case "2":
                        OperacionBasica("-");
                        break;
                    case "3":
                        OperacionBasica("*");
                        break;
                    case "4":
                        OperacionBasica("/");
                        break;
                    case "5":
                        RaizCuadrada();
                        break;
                    case "6":
                        CalcularExpresion();
                        break;
                    case "7":
                        Logaritmo();
                        break;
                    case "8":
                        Seno();
                        break;
                    case "9":
                        Coseno();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("⚠ Opción inválida. Presione una tecla para continuar...");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void OperacionBasica(string operador)
        {
            Console.Clear();
            Console.Write("Ingrese el primer número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            double resultado = 0;

            switch (operador)
            {
                case "+": resultado = num1 + num2; break;
                case "-": resultado = num1 - num2; break;
                case "*": resultado = num1 * num2; break;
                case "/":
                    if (num2 != 0)
                        resultado = num1 / num2;
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("❌ Error: División entre cero");
                        Console.ResetColor();
                        Console.ReadKey();
                        return;
                    }
                    break;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n✅ Resultado: {resultado}");
            Console.ResetColor();
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }

        static void RaizCuadrada()
        {
            Console.Clear();
            Console.Write("Ingrese un número: ");
            double num = double.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("❌ Error: No se puede calcular raíz cuadrada de un número negativo");
                Console.ResetColor();
            }
            else
            {
                double resultado = Math.Sqrt(num);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n✅ Resultado: {resultado}");
                Console.ResetColor();
            }

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }

        static void CalcularExpresion()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la expresión (puede usar +, -, *, /, paréntesis, sqrt() para raíz):");
            string expresion = Console.ReadLine();

            try
            {
                var resultado = new System.Data.DataTable().Compute(expresion, null);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n✅ Resultado: {resultado}");
                Console.ResetColor();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("❌ Error: Expresión inválida");
                Console.ResetColor();
            }

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }

        static void Logaritmo()
        {
            Console.Clear();
            Console.Write("Ingrese un número: ");
            double num = double.Parse(Console.ReadLine());

            if (num <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("❌ Error: El logaritmo solo está definido para números positivos");
                Console.ResetColor();
            }
            else
            {
                double resultado = Math.Log10(num);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n✅ Resultado: {resultado}");
                Console.ResetColor();
            }

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }

        static void Seno()
        {
            Console.Clear();
            Console.Write("Ingrese el ángulo en grados: ");
            double grados = double.Parse(Console.ReadLine());
            double radianes = grados * Math.PI / 180;
            double resultado = Math.Sin(radianes);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n✅ Resultado: {resultado}");
            Console.ResetColor();

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }

        static void Coseno()
        {
            Console.Clear();
            Console.Write("Ingrese el ángulo en grados: ");
            double grados = double.Parse(Console.ReadLine());
            double radianes = grados * Math.PI / 180;
            double resultado = Math.Cos(radianes);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n✅ Resultado: {resultado}");
            Console.ResetColor();

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
