//Implementar una función que calcule el factorial de un número n.
using System;

class Program
{
   
    public static int FactorialRecursivo(int n)
    {
        if (n < 0)
            throw new ArgumentException("El número debe ser no negativo.");

        if (n <= 1)
            return 1;

        return n * FactorialRecursivo(n - 1);
    }

   
    static void Main(string[] args)
    {
        Console.Write("Ingresa un número: ");
        int numero = int.Parse(Console.ReadLine());

        int resultado = FactorialRecursivo(numero);
        Console.WriteLine($"El factorial de {numero} es: {resultado}");
    }
}
