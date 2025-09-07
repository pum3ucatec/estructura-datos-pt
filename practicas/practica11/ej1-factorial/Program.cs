//1. Factorial de un número
// Pregunta:
// Implementar una función que calcule el factorial de un número n.

using System;

class Ejercicio1
{
    // Función recursiva que calcula el factorial de n
    public static int FactorialRecursivo(int n)
    {
        if (n == 0 || n == 1) // Caso base
            return 1;
        return n * FactorialRecursivo(n - 1); // Llamada recursiva
    }

    static void Main()
    {
        Console.Write("Ingresa un número: ");
        int numero = int.Parse(Console.ReadLine());

        int resultado = FactorialRecursivo(numero);

        Console.WriteLine($"El factorial de {numero} es: {resultado}");
    }
}

