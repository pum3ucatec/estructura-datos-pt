using System;

class Program
{
    // Función recursiva para calcular el factorial
    public static int Factorial(int n)
    {
        // Caso base
        if (n == 0 || n == 1)
            return 1;

        // Caso recursivo
        return n * Factorial(n - 1);
    }

    static void Main(string[] args)
    {
        Console.Write("Ingrese un número para calcular su factorial: ");
        int numero = int.Parse(Console.ReadLine());

        int resultado = Factorial(numero);

        Console.WriteLine($"El factorial de {numero} es: {resultado}");
    }
}