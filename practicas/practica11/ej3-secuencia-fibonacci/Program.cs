//3. Secuencia de Fibonacci
// Pregunta:
// Calcular el término n de la secuencia de Fibonacci.
//Cami
using System;

class Ejercicio3
{
    public static int FibonacciRecursivo(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        return FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2);
    }

    static void Main()
    {
        Console.Write("Ingrese la posición n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"El término {n} de Fibonacci es: {FibonacciRecursivo(n)}");
    }
}

