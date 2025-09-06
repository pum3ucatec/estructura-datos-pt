using System;

class Program
{
    static int Triangular(int n)
    {
        if (n == 1) return 1;
        return n + Triangular(n - 1);
    }

    static void Main()
    {
        Console.Write("Ingrese un número para calcular su número triangular: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"El número triangular de {n} es {Triangular(n)}");
    }
}
