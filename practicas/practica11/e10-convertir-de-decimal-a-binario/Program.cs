using System;

class Ejercicio10
{
    public static string DecimalBinario(int n)
    {
        if (n == 0) return "0";  // caso base
        if (n == 1) return "1";  // caso base
        return DecimalBinario(n / 2) + (n % 2); // llamada recursiva
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Decimal a Binario Recursivo ===");

        Console.Write("Ingresa un número entero: ");
        int num = int.Parse(Console.ReadLine());

        string binario = DecimalBinario(num);

        Console.WriteLine($"El número {num} en binario es: {binario}");
    }
}
