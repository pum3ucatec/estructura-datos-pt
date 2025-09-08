// Contar la cantidad de dígitos que tiene un número entero positivo.
using System;

class Program
{

    public static int ContarDigitosRecursivo(int n)
    {
        if (n < 0)
            throw new ArgumentException("El número debe ser positivo.");

        if (n < 10)
            return 1;

        return 1 + ContarDigitosRecursivo(n / 10);
    }

    static void Main(string[] args)
    {
        Console.Write("Ingresa un número entero positivo: ");
        if (int.TryParse(Console.ReadLine(), out int numero) && numero > 0)
        {
            int cantidad = ContarDigitosRecursivo(numero);
            Console.WriteLine($"El número {numero} tiene {cantidad} dígito(s).");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor ingresa un número entero positivo.");
        }
    }
}

