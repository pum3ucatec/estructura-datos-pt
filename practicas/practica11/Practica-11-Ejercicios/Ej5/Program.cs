using System;

class Program
{
    static int SumaDigitos(int n)
    {
        if (n == 0) return 0;
        return (n % 10) + SumaDigitos(n / 10);
    }

    static void Main()
    {
        Console.Write("Ingrese un número para sumar sus dígitos: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"La suma de los dígitos de {n} es {SumaDigitos(n)}");
    }
}
