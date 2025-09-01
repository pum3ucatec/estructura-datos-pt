using System;

class Ejercicio8
{
    static void Main()
    {
        Console.Write("Ingrese un número para verificar si es primo: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero <= 1)
        {
            Console.WriteLine($"{numero} no es un número primo.");
            return;
        }

        bool esPrimo = true;
        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                esPrimo = false;
                break;
            }
        }

        if (esPrimo)
            Console.WriteLine($"{numero} es un número primo.");
        else
            Console.WriteLine($"{numero} no es un número primo.");
    }
}
