using System;

class Program
{
    static int MCD(int a, int b)
    {
        if (b == 0) return a;
        return MCD(b, a % b);
    }

    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        int a = int.Parse(Console.ReadLine()!);
        Console.Write("Ingrese el segundo número: ");
        int b = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"El MCD de {a} y {b} es {MCD(a, b)}");
    }
}
