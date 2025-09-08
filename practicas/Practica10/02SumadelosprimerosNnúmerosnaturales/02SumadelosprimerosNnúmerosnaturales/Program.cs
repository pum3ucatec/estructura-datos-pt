//Suma de los primeros N números naturales
using System;

class Program
{

    public static int SumaRecursiva(int n)
    {
        if (n < 0)
            throw new ArgumentException("El número debe ser no negativo.");

        if (n == 0)
            return 0;

        return n + SumaRecursiva(n - 1);
    }

 
    static void Main(string[] args)
    {
        Console.Write("Ingresa un número entero no negativo: ");
        if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 0)
        {
            int resultado = SumaRecursiva(numero);
            Console.WriteLine($"La suma de los primeros {numero} números naturales es: {resultado}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor ingresa un número entero no negativo.");
        }
    }
}
