using System;
class Ejercicio1
{
    public static int Factorial(int n)
    {
        if (n == 0 || n == 1) 
            return 1;
        return n * Factorial(n - 1);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Factorial ===");

        Console.Write("Ingresa un número: ");
        int num = int.Parse(Console.ReadLine());

        int resultado = factorial(num);

        Console.WriteLine($"El factorial de {num} es: {resultado}");
    }
}