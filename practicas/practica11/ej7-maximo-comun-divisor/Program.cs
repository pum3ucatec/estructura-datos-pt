// 7. Máximo Común Divisor (MCD)
// Pregunta:
// Calcular el máximo común divisor (MCD) de dos números.
using System;

class Ejercicio7
{
    public static int MCDRecursivo(int a, int b)
    {
        if (b == 0)
            return a;
        return MCDRecursivo(b, a % b);
    }

    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"El MCD de {a} y {b} es: {MCDRecursivo(a, b)}");
    }
}

