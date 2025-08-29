//Realizar una calculadora cientifica en C Sharp.
using System;

class CalculadoraCientifica
{
    static void Main()
    {
        Console.WriteLine("🔬 Calculadora Científica en C#");
        Console.WriteLine("Seleccione una operación:");
        Console.WriteLine("1. Suma\n2. Resta\n3. Multiplicación\n4. División");
        Console.WriteLine("5. Potencia\n6. Raíz cuadrada\n7. Seno\n8. Coseno\n9. Tangente");
        Console.WriteLine("10. Logaritmo\n11. Exponencial\n12. Factorial");

        int opcion = int.Parse(Console.ReadLine());
        double a, b;

        switch (opcion)
        {
            case 1:
                Console.Write("Ingrese el primer número: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {a + b}");
                break;

            case 2:
                Console.Write("Ingrese el primer número: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {a - b}");
                break;

            case 3:
                Console.Write("Ingrese el primer número: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {a * b}");
                break;

            case 4:
                Console.Write("Ingrese el dividendo: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el divisor: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine(b != 0 ? $"Resultado: {a / b}" : "Error: División por cero");
                break;

            case 5:
                Console.Write("Base: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Exponente: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {Math.Pow(a, b)}");
                break;

            case 6:
                Console.Write("Número: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {Math.Sqrt(a)}");
                break;

            case 7:
                Console.Write("Ángulo en grados: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine($"Seno: {Math.Sin(a * Math.PI / 180)}");
                break;

            case 8:
                Console.Write("Ángulo en grados: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine($"Coseno: {Math.Cos(a * Math.PI / 180)}");
                break;

            case 9:
                Console.Write("Ángulo en grados: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine($"Tangente: {Math.Tan(a * Math.PI / 180)}");
                break;

            case 10:
                Console.Write("Número: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine($"Logaritmo natural: {Math.Log(a)}");
                break;

            case 11:
                Console.Write("Número: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine($"Exponencial: {Math.Exp(a)}");
                break;

            case 12:
                Console.Write("Número entero: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Factorial: {Factorial(n)}");
                break;

            default:
                Console.WriteLine("Opción inválida.");
                break;
        }
    }

    static long Factorial(int n)
    {
        if (n < 0) return -1;
        long result = 1;
        for (int i = 2; i <= n; i++)
            result *= i;
        return result;
    }
}

