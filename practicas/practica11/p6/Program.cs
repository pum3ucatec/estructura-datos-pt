using System;

class ContarDigitosRecursivo
{
    static int ContarDigitos(int n)
    {
        if (n == 0) return 0;
        return 1 + ContarDigitos(n / 10);
    }

    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Cantidad de dígitos: {ContarDigitos(n)}");
    }
}
