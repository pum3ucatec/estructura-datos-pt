using System;

class NumeroPrimo
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        if (EsPrimo(numero))
            Console.WriteLine($"{numero} es primo.");
        else
            Console.WriteLine($"{numero} no es primo.");
    }

    static bool EsPrimo(int n)
    {
        if (n <= 1) return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
}
