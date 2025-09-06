using System;

class Program
{
    static int Potencia(int a, int b)
    {
        if (b == 0) return 1;
        return a * Potencia(a, b - 1);
    }

    static void Main()
    {
        Console.Write("Ingrese la base: ");
        int a = int.Parse(Console.ReadLine()!);
        Console.Write("Ingrese el exponente: ");
        int b = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"{a}^{b} = {Potencia(a, b)}");
    }
}
