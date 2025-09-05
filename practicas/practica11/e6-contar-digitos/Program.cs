using System;
class Ejercicio6
{
    public static int ContarDigitos(int n)
    {
        if (n < 10) 
            return 1;
        return 1 + ContarDigitos(n / 10);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Contar Dígitos ===");

        Console.Write("Ingresa un número: ");
        int num = int.Parse(Console.ReadLine());

        int resultado = ContarDigitos(num);

        Console.WriteLine($"El número {num} tiene {resultado} dígitos.");
    }
}