/*Calculadora científica basica (5 funciones.
Suma, Resta, Multiplicacion, Division y Porcentaje. */

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
    Console.WriteLine("0) Salir");
    Console.Write("Elige una opción: ");

    // Lee la opción del menu
    string? opTexto = Console.ReadLine();
	if (!int.TryParse(opTexto, out int opcion))
	{
		Console.WriteLine("Opción inválida. Intenta de nuevo.");
		continue; // si pone otro numero la vuelve a pedir
    }

    if (opcion == 0)
    {
        Console.WriteLine("¡Byee!  ");
        break; 
    }

    // Pedimos números según la operación
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
            double resultado = PorcentajeDe(x, y);
            Console.WriteLine($"{Form(y)}% de {Form(x)} = {Form(resultado)}");
            break;

        default:
            Console.WriteLine("Opción inválida. Intenta de nuevo.");
            break;
    }
}

/* funciones de calculp
solo reciben números y devuelven el resultado. */ 

double Sumar(double x, double y) => x + y;
double Restar(double x, double y) => x - y;
double Multiplicar(double x, double y) => x * y;
double Dividir(double x, double y) => x / y;
double PorcentajeDe(double numeroBase, double porcentaje) => numeroBase * porcentaje / 100.0;
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
