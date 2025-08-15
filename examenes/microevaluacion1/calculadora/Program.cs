using System;

class CalculadoraCientifica
{
    static void Main()
    {
        Console.WriteLine("Calculadora Científica Básica");
        Console.WriteLine("Funciones disponibles:");
        Console.WriteLine("1) Suma (+)");
        Console.WriteLine("2) Resta (-)");
        Console.WriteLine("3) Multiplicación (*)");
        Console.WriteLine("4) División (/)");
        Console.WriteLine("5) Potencia (x^y)");
        Console.WriteLine("6) Raíz cuadrada (√x)");
        Console.WriteLine("7) Logaritmo base 10 (log10)");
        Console.WriteLine("8) Seno (sin)");
        Console.WriteLine("9) Coseno (cos)");
        Console.WriteLine("10) Tangente (tan)");

        while (true)
        {
            Console.Write("\nSelecciona una función (1-10) o 0 para salir: ");
            string opcion = Console.ReadLine();

            if (opcion == "0")
            {
                Console.WriteLine("Saliendo de la calculadora. ¡Hasta luego!");
                break;
            }

            switch (opcion)
            {
                case "1":
                    RealizarOperacionBinaria((a, b) => a + b, "Suma");
                    break;
                case "2":
                    RealizarOperacionBinaria((a, b) => a - b, "Resta");
                    break;
                case "3":
                    RealizarOperacionBinaria((a, b) => a * b, "Multiplicación");
                    break;
                case "4":
                    RealizarOperacionBinaria(Division, "División");
                    break;
                case "5":
                    RealizarOperacionBinaria(Math.Pow, "Potencia");
                    break;
                case "6":
                    RealizarOperacionUnaria(Math.Sqrt, "Raíz cuadrada");
                    break;
                case "7":
                    RealizarOperacionUnaria(Math.Log10, "Logaritmo base 10");
                    break;
                case "8":
                    RealizarOperacionUnaria(a => Math.Sin(DegToRad(a)), "Seno (grados)");
                    break;
                case "9":
                    RealizarOperacionUnaria(a => Math.Cos(DegToRad(a)), "Coseno (grados)");
                    break;
                case "10":
                    RealizarOperacionUnaria(a => Math.Tan(DegToRad(a)), "Tangente (grados)");
                    break;
                default:
                    Console.WriteLine("Opción no válida, intenta de nuevo.");
                    break;
            }
        }
    }

    static void RealizarOperacionBinaria(Func<double, double, double> operacion, string nombre)
    {
        Console.WriteLine($"\n{nombre}");
        double a = LeerNumero("Ingresa el primer número: ");
        double b = LeerNumero("Ingresa el segundo número: ");
        try
        {
            double resultado = operacion(a, b);
            Console.WriteLine($"Resultado: {resultado}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al calcular: {ex.Message}");
        }
    }

    static void RealizarOperacionUnaria(Func<double, double> operacion, string nombre)
    {
        Console.WriteLine($"\n{nombre}");
        double a = LeerNumero("Ingresa el número: ");
        try
        {
            double resultado = operacion(a);
            Console.WriteLine($"Resultado: {resultado}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al calcular: {ex.Message}");
        }
    }

    static double LeerNumero(string mensaje)
    {
        double valor;
        Console.Write(mensaje);
        while (!double.TryParse(Console.ReadLine(), out valor))
        {
            Console.WriteLine("Entrada inválida, por favor ingresa un número válido.");
            Console.Write(mensaje);
        }
        return valor;
    }

    static double Division(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("No se puede dividir entre cero.");
        return a / b;
    }

    static double DegToRad(double grados)
    {
        return grados * Math.PI / 180.0;
    }
}
