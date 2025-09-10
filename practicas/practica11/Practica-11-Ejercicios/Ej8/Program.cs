using System;

class Program
{
    static int InvertirNumero(int n, int invertido = 0)
    {
        if (n == 0) return invertido;
        return InvertirNumero(n / 10, invertido * 10 + (n % 10));
    }

    static void Main()
    {
        Console.Write("Ingrese un número para invertir: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"El número invertido es {InvertirNumero(n)}");
    }
}
