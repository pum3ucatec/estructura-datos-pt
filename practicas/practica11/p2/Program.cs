using System;

class SumaNRecursivo
{
    static int Suma(int n)
    {
        if (n <= 0) return 0;
        return n + Suma(n - 1);
    }

    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"La suma de los primeros {n} números es: {Suma(n)}");
    }
}
