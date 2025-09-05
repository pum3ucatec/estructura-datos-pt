using System;

class Program
{
    static void Main()
    {
        Console.Write("Escribe un número: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 2)
        {
            Console.WriteLine($"{n} NO es primo.");
            return;
        }

        bool esPrimo = true;

        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                esPrimo = false;
                break;
            }
        }

        if (esPrimo)
            Console.WriteLine($"{n} SÍ es primo.");
        else
            Console.WriteLine($"{n} NO es primo.");
    }
}
