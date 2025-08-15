/* Calculadora científica básica (9 funciones)
Suma, Resta, Multiplicación, División, Porcentaje, Potencia, Raiz cuadrada, Factorial, Logaritmo base 10 */

using System;
using System.Globalization; // para manejar coma/punto como separador decimal

// programa principal
while (true)
{
    Console.WriteLine("\n=== CALCULADORA ===");
    Console.WriteLine("1) Sumar");
    Console.WriteLine("2) Restar");
    Console.WriteLine("3) Multiplicar");
    Console.WriteLine("4) Dividir");
    Console.WriteLine("5) Porcentaje");
    Console.WriteLine("6) Potencia");
    Console.WriteLine("7) Raíz cuadrada");
    Console.WriteLine("8) Factorial");
    Console.WriteLine("9) Logaritmo base 10");
    Console.WriteLine("0) Salir");
    Console.Write("Elige una opción: ");

    // Lee la opción del menu
    string? opTexto = Console.ReadLine();
    if (!int.TryParse(opTexto, out int opcion))
    {
        Console.WriteLine("Opción inválida. Intenta de nuevo.");
        continue; // si pone otro número, vuelve a pedir
    }

    if (opcion == 0)
    {
        Console.WriteLine("¡Byee!");
        break; 
    }

    // Variables para entrada de datos
    double x, y;

    switch (opcion)
    {
        case 1: // Suma
            x = LeerNumero("Ingrese el 1er número: ");
            y = LeerNumero("Ingrese el 2do número: ");
            MostrarResultado(x, y, "+", Sumar(x, y));
            break;

        case 2: // Resta
            x = LeerNumero("Ingrese el minuendo: ");
            y = LeerNumero("Ingrese el sustraendo: ");
            MostrarResultado(x, y, "-", Restar(x, y));
            break;

        case 3: // Multiplicacion
            x = LeerNumero("Ingrese el 1er factor: ");
            y = LeerNumero("Ingrese el 2do factor: ");
            MostrarResultado(x, y, "×", Multiplicar(x, y));
            break;

        case 4: // Division
            x = LeerNumero("Ingrese el dividendo: ");
            y = LeerNumero("Ingrese el divisor: ");
            if (y == 0)
            {
                Console.WriteLine("Error: No se puede dividir entre cero.");
            }
            else
            {
                MostrarResultado(x, y, "÷", Dividir(x, y));
            }
            break;

        case 5: // Porcentaje 
            x = LeerNumero("Ingrese el número: ");
            y = LeerNumero("Ingrese el porcentaje (ej. 15 para 15%): ");
            double resultadoPorc = PorcentajeDe(x, y);
            Console.WriteLine($"{Form(y)}% de {Form(x)} = {Form(resultadoPorc)}");
            break;

        case 6: // Potencia
            x = LeerNumero("Ingrese la base: ");
            y = LeerNumero("Ingrese el exponente: ");
            MostrarResultado(x, y, "^", Potencia(x, y));
            break;

        case 7: // Rai cuadraa
            x = LeerNumero("Ingrese el número: ");
            if (x < 0)
                Console.WriteLine("Error: No se puede calcular la raíz cuadrada de un número negativo.");
            else
                Console.WriteLine($"√{Form(x)} = {Form(RaizCuadrada(x))}");
            break;

        case 8: // Factorial
            x = LeerNumero("Ingrese un número entero no negativo: ");
            if (x < 0 || x != Math.Floor(x))
            {
                Console.WriteLine("Error: El factorial solo está definido para enteros no negativos.");
            }
            else
            {
                Console.WriteLine($"{Form(x)}! = {Form(Factorial((int)x))}");
            }
            break;

        case 9: // Logaritmo base10
            x = LeerNumero("Ingrese el número: ");
            if (x <= 0)
                Console.WriteLine("Error: No se puede calcular log10 de cero o número negativo.");
            else
                Console.WriteLine($"log10({Form(x)}) = {Form(LogBase10(x))}");
            break;

        default:
            Console.WriteLine("Opción inválida. Intenta de nuevo.");
            break;
    }
}

/* funciones de cálculo 
   solo reciben números y devuelven el resultado. */ 

double Sumar(double x, double y) => x + y;
double Restar(double x, double y) => x - y;
double Multiplicar(double x, double y) => x * y;
double Dividir(double x, double y) => x / y;
double PorcentajeDe(double numeroBase, double porcentaje) => numeroBase * porcentaje / 100.0;
double Potencia(double baseNum, double exponente) => Math.Pow(baseNum, exponente);
double RaizCuadrada(double num) => Math.Sqrt(num);
double LogBase10(double num) => Math.Log10(num);

// Factorial implementado iterativamente
long Factorial(int n)
{
    long resultado = 1;
    for (int i = 1; i <= n; i++)
    {
        resultado *= i;
    }
    return resultado;
}

double LeerNumero(string mensaje)
{
    while (true)
    {
        Console.Write(mensaje);
        string? texto = Console.ReadLine();

        if (double.TryParse(texto, NumberStyles.Float, CultureInfo.CurrentCulture, out double n))
            return n;

        if (double.TryParse(texto, NumberStyles.Float, CultureInfo.InvariantCulture, out n))
            return n;

        Console.WriteLine("Entrada inválida. Escribe un número válido (ej: 12.5 o 12,5).");
    }
}

void MostrarResultado(double A, double B, string op, double resultado)
{
    Console.WriteLine($"{Form(A)} {op} {Form(B)} = {Form(resultado)}");
}

string Form(double n) => n.ToString("G15", CultureInfo.CurrentCulture);
