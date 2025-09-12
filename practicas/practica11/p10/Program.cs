using System;

class DecimalABinarioRecursivo
{
    static string DecimalABinario(int n)
    {
        if (n == 0) return "0";
        if (n == 1) return "1";
        return DecimalABinario(n / 2) + (n % 2);
    }

    static void Main()
    {
        Console.Write("Ingrese un número decimal: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Número en binario: {DecimalABinario(n)}");
    }
}
