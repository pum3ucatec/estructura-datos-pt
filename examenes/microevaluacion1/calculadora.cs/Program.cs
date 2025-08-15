using System;

class Calculadora
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("==== Calculadora Científica ====");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Raíz Cuadrada");
            Console.WriteLine("6. Potencia");
            Console.WriteLine("7. Logaritmo (base 10)");
            Console.WriteLine("8. Seno");
            Console.WriteLine("9. Coseno");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    OperacionBinaria((a, b) => a + b, "Suma");
                    break;
                case "2":
                    OperacionBinaria((a, b) => a - b, "Resta");
                    break;
                case "3":
                    OperacionBinaria((a, b) => a * b, "Multiplicación");
                    break;
                case "4":
                    OperacionBinaria((a, b) => b != 0 ? a / b : double.NaN, "División");
                    break;
                case "5":
                    OperacionUnaria(Math.Sqrt, "Raíz Cuadrada");
                    break;
                case "6":
                    Potencia();
                    break;
                case "7":
                    OperacionUnaria(Math.Log10, "Logaritmo base 10");
                    break;
                case "8":
                    OperacionUnaria(Math.Sin, "Seno");
                    break;
                case "9":
                    OperacionUnaria(Math.Cos, "Coseno");
                    break;
                case "0":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            if (continuar)
            {
                Console.WriteLine("\nPresiona una tecla para continuar...");
                Console.ReadKey();
            }
        }
    }

    static void OperacionBinaria(Func<double, double, double> operacion, string nombre)
    {
        Console.Write($"\nIngrese el primer número para {nombre}: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write($"Ingrese el segundo número para {nombre}: ");
        double b = double.Parse(Console.ReadLine());

        double resultado = operacion(a, b);
        Console.WriteLine($"\nResultado de la {nombre}: {resultado}");
    }

    static void OperacionUnaria(Func<double, double> operacion, string nombre)
    {
        Console.Write($"\nIngrese un número para {nombre}: ");
        double a = double.Parse(Console.ReadLine());

        double resultado = operacion(a);
        Console.WriteLine($"\nResultado de la {nombre}: {resultado}");
    }

    static void Potencia()
    {
        Console.Write("\nIngrese la base: ");
        double baseNum = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el exponente: ");
        double exponente = double.Parse(Console.ReadLine());

        double resultado = Math.Pow(baseNum, exponente);
        Console.WriteLine($"\nResultado de la Potencia: {resultado}");
    }
}
