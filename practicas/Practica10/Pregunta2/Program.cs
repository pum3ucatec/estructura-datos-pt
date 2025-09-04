using System;

class Program
{
    // Método recursivo para sumar los primeros N números naturales
    public static int SumaRecursiva(int n)
    {
        // Caso base
        if (n == 0)
            return 0;

        // Caso recursivo
        return n + SumaRecursiva(n - 1);
    }

    static void Main(string[] args)
    {
        Console.Write("Ingrese un número: ");
        int n = int.Parse(Console.ReadLine());

        int resultado = SumaRecursiva(n);
        Console.WriteLine($"La suma de los primeros {n} números naturales es: {resultado}");
    }
}