using System;

class Calculadora
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("=== CALCULADORA ===");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Potencia");
            Console.WriteLine("6. Raíz cuadrada");
            Console.WriteLine("7. Módulo");
            Console.WriteLine("8. Valor absoluto");
            Console.WriteLine("9. Factorial");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());

            double num1, num2, resultado;

            switch (opcion)
            {
                case 1:
                    num1 = PedirNumero("Ingresa el primer número: ");
                    num2 = PedirNumero("Ingresa el segundo número: ");
                    resultado = Suma(num1, num2);
                    Console.WriteLine($"Resultado: {resultado}");
                    break;

                case 2:
                    num1 = PedirNumero("Ingresa el primer número: ");
                    num2 = PedirNumero("Ingresa el segundo número: ");
                    resultado = Resta(num1, num2);
                    Console.WriteLine($"Resultado: {resultado}");
                    break;

                case 3:
                    num1 = PedirNumero("Ingresa el primer número: ");
                    num2 = PedirNumero("Ingresa el segundo número: ");
                    resultado = Multiplicacion(num1, num2);
                    Console.WriteLine($"Resultado: {resultado}");
                    break;

                case 4:
                    num1 = PedirNumero("Ingresa el dividendo: ");
                    num2 = PedirNumero("Ingresa el divisor: ");
                    if (num2 != 0)
                        Console.WriteLine($"Resultado: {Division(num1, num2)}");
                    else
                        Console.WriteLine("Error: no se puede dividir entre 0.");
                    break;

                case 5:
                    num1 = PedirNumero("Ingresa la base: ");
                    num2 = PedirNumero("Ingresa el exponente: ");
                    Console.WriteLine($"Resultado: {Potencia(num1, num2)}");
                    break;

                case 6:
                    num1 = PedirNumero("Ingresa el número: ");
                    if (num1 >= 0)
                        Console.WriteLine($"Resultado: {RaizCuadrada(num1)}");
                    else
                        Console.WriteLine("Error: no se puede calcular la raíz cuadrada de un número negativo.");
                    break;

                case 7:
                    num1 = PedirNumero("Ingresa el primer número: ");
                    num2 = PedirNumero("Ingresa el segundo número: ");
                    Console.WriteLine($"Resultado: {Modulo(num1, num2)}");
                    break;

                case 8:
                    num1 = PedirNumero("Ingresa un número: ");
                    Console.WriteLine($"Resultado: {ValorAbsoluto(num1)}");
                    break;

                case 9:
                    Console.Write("Ingresa un número entero: ");
                    int n = int.Parse(Console.ReadLine());
                    if (n >= 0)
                        Console.WriteLine($"Resultado: {Factorial(n)}");
                    else
                        Console.WriteLine("Error: el factorial solo está definido para enteros no negativos.");
                    break;

                case 0:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            if (opcion != 0)
            {
                Console.WriteLine("\nPresiona una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 0);
    }

    // FUNCIONES MATEMÁTICAS
    static double PedirNumero(string mensaje)
    {
        Console.Write(mensaje);
        return double.Parse(Console.ReadLine());
    }

    static double Suma(double a, double b) => a + b;
    static double Resta(double a, double b) => a - b;
    static double Multiplicacion(double a, double b) => a * b;
    static double Division(double a, double b) => a / b;
    static double Potencia(double a, double b) => Math.Pow(a, b);
    static double RaizCuadrada(double a) => Math.Sqrt(a);
    static double Modulo(double a, double b) => a % b;
    static double ValorAbsoluto(double a) => Math.Abs(a);
    static long Factorial(int n)
    {
        long resultado = 1;
        for (int i = 1; i <= n; i++)
            resultado *= i;
        return resultado;
    }
}
