using System;

class Program
{
    public static int MCD(int a, int b)
    {
        if (b == 0)
            return a;
        return MCD(b, a % b);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Calcular MCD (Recursivo) ===");

        Console.Write("Ingresa el primer número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        int resultado = MCD(num1, num2);

        Console.WriteLine($"El MCD de {num1} y {num2} es: {resultado}");
    }
}