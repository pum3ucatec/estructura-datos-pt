// Convertir un número decimal en su representación binaria.
using System;

class Program
{

    public static string DecimalABinarioRecursivo(int n)
    {
        if (n < 0)
            throw new ArgumentException("El número debe ser no negativo.");

        if (n == 0)
            return "0";

        if (n == 1)
            return "1";

        return DecimalABinarioRecursivo(n / 2) + (n % 2).ToString();
    }

    static void Main(string[] args)
    {
        Console.Write("Ingresa un número entero no negativo: ");
        if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 0)
        {
            string binario = DecimalABinarioRecursivo(numero);
            Console.WriteLine($"El número {numero} en binario es: {binario}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor ingresa un número entero no negativo.");
        }
    }
}
