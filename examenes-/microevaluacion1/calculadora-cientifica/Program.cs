using System;
using System.Globalization;

class Calculadora
{
    static double PedirNumero(string label)
    {
        Console.Write($"{label}: ");
        double n; // <-- declarar antes del while
        while (!double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out n))
        {
            Console.Write("Valor inválido. Intenta de nuevo: ");
        }
        return n; // ahora sí existe en este contexto
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Calculadora Científica (6 funciones) ===");
            Console.WriteLine("1) Suma");
            Console.WriteLine("2) Resta");
            Console.WriteLine("3) Multiplicación");
            Console.WriteLine("4) División");
            Console.WriteLine("5) Potencia");
            Console.WriteLine("6) Raíz cuadrada");
            Console.WriteLine("0) Salir");
            Console.Write("Elige una opción: ");

            var opcion = Console.ReadLine();

            if (opcion == "0") break;

            double a, b;

            switch (opcion)
            {
                case "1":
                    a = PedirNumero("A");
                    b = PedirNumero("B");
                    Console.WriteLine($"Resultado: {a + b}");
                    break;

                case "2":
                    a = PedirNumero("A");
                    b = PedirNumero("B");
                    Console.WriteLine($"Resultado: {a - b}");
                    break;

                case "3":
                    a = PedirNumero("A");
                    b = PedirNumero("B");
                    Console.WriteLine($"Resultado: {a * b}");
                    break;

                case "4":
                    a = PedirNumero("A");
                    b = PedirNumero("B");
                    if (b == 0) Console.WriteLine("Error: división entre cero.");
                    else Console.WriteLine($"Resultado: {a / b}");
                    break;

                case "5":
                    a = PedirNumero("Base");
                    b = PedirNumero("Exponente");
                    Console.WriteLine($"Resultado: {Math.Pow(a, b)}");
                    break;

                case "6":
                    a = PedirNumero("Número");
                    if (a < 0) Console.WriteLine("Error: raíz de número negativo.");
                    else Console.WriteLine($"Resultado: {Math.Sqrt(a)}");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        Console.WriteLine("¡Hasta luego!");
    }
}
