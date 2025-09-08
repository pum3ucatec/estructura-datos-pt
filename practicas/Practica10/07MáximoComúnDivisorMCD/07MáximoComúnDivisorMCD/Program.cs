//Calcular el máximo común divisor (MCD) de dos números.
using System;

class Program
{

    public static int MCDRecursivo(int a, int b)
    {
        if (b == 0)
            return Math.Abs(a);

        return MCDRecursivo(b, a % b);
    }

    static void Main(string[] args)
    {
        Console.Write("Ingresa el primer número: ");
        bool validoA = int.TryParse(Console.ReadLine(), out int a);

        Console.Write("Ingresa el segundo número: ");
        bool validoB = int.TryParse(Console.ReadLine(), out int b);

        if (validoA && validoB)
        {
            int resultado = MCDRecursivo(a, b);
            Console.WriteLine($"El MCD de {a} y {b} es: {resultado}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor ingresa dos números enteros.");
        }
    }
}
