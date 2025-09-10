using System;

class Program
{
    static int ContarDigitos(int n)
    {
        if (n == 0) return 0;
        return 1 + ContarDigitos(n / 10);
    }

    static void Main()
    {
        Console.Write("Ingrese un número para contar sus dígitos: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"El número {n} tiene {ContarDigitos(n)} dígitos");
    }
}
