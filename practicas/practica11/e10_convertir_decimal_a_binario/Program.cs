using System;

class ejercicio_10
{
    public static string decimal_binario(int n)
    {
        if (n == 0) return "";
        return decimal_binario(n / 2) + (n % 2);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Decimal a Binario ===");

        Console.Write("Ingresa un número decimal: ");
        int num = int.Parse(Console.ReadLine());

        string binario = decimal_binario(num);

        Console.WriteLine($"El número {num} en binario es: {binario}");
    }
}